using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemonChatServer
{
    public partial class LemonChatServerIndexForm : Form
    {

        private delegate void AddItemToListBoxDelegate(string message);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        private void AddItemToListBox(string v)
        {
            if (ListboxStatus.InvokeRequired)
            {
                AddItemToListBoxDelegate listBoxDelegate = AddItemToListBox;
                ListboxStatus.Invoke(listBoxDelegate);
            }
            else
            {
                ListboxStatus.Items.Add(v);
                ListboxStatus.TopIndex = ListboxStatus.Items.Count - 1;
                ListboxStatus.ClearSelected();
            }
        }



        // 保存登录的所有用户
        private List<User> userList = new List<User>();

        // 服务器端口
        int port;
        // 监听端口
        int tcpPort;
        //定义变量
        private UdpClient sendUdpClient;
        private UdpClient receiveUdpClient;
        private IPEndPoint serverIpEndPoint;
        private IPAddress serverIp;
        private TcpListener tcpListener;
        private NetworkStream networkStream;
        private BinaryWriter binaryWriter;
        private string userListString;

        public LemonChatServerIndexForm()
        {
            InitializeComponent();
            IPAddress[] serverIps = Dns.GetHostAddresses("");
            IpTextBox.Text = serverIps[1].ToString();

            Random random = new Random();
            port = random.Next(1024, 65500);

            PortTextBox.Text = port.ToString();
            StopServerButton.Enabled = false;

        }

  


        private void StartServerButton_Click(object sender, EventArgs e)
        {

            serverIp = IPAddress.Parse(IpTextBox.Text);
            serverIpEndPoint = new IPEndPoint(serverIp,int.Parse(PortTextBox.Text));
            UdpClient receiveUdpClient = new UdpClient(serverIpEndPoint);

            //启动接收线程
            Thread receiveThread = new Thread(ReceiveMessage);
            receiveThread.Start();
            StartServerButton.Enabled = false;
            StopServerButton.Enabled = true;

            //随机指定监听端口
            Random random = new Random();
            tcpPort = random.Next(port + 1, 65536);

            // 创建监听套接字
            tcpListener = new TcpListener(serverIp, tcpPort);
            tcpListener.Start();


            // 启动监听线程
            Thread listenThread = new Thread(ListenClientContent);
            listenThread.Start();
            AddItemToListBox(string.Format("服务器线程{0}启动，监听端口{1}",serverIpEndPoint,tcpPort));

        }

        private void ListenClientContent()
        {
            TcpClient newClient = null;
            while (true)
            {
                try
                {
                    newClient = tcpListener.AcceptTcpClient();
                    AddItemToListBox(string.Format("接收客户端{0}的TCP请求",newClient.Client.RemoteEndPoint));
                }
                catch
                {
                    AddItemToListBox(string.Format("监听线程{0}:{1}", serverIp, tcpPort));
                    break;
                }

                Thread sendThread = new Thread(sendData);
                sendThread.Start();
            }
        }

        /// <summary>
        /// 向客户端发送在线用户列表信息
        /// </summary>
        private void sendData(object userClient)
        {
            TcpClient newUserCLient = userClient as TcpClient;
            userListString = null;

            for (int i=0;i< userList.Count;i++)
            {
                userListString += userList[i].GetName() + ","
                    + userList[i].GetIPEndPoint().ToString()+";";
            }

            userListString += "end";
            networkStream = newUserCLient.GetStream();
            binaryWriter = new BinaryWriter(networkStream);
            binaryWriter.Write(userListString);
            binaryWriter.Flush();
            AddItemToListBox(string.Format("向{0}发送{1}", newUserCLient.Client.RemoteEndPoint, userListString));
            binaryWriter.Close();
            newUserCLient.Close();
        }

        /// <summary>
        /// 接收客户端发来的消息
        /// </summary>
        private void ReceiveMessage()
        {
            IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                try
                {
                    byte[] receiveBytes = receiveUdpClient.Receive(ref remoteIpEndPoint);
                    string message = Encoding.Unicode.GetString(receiveBytes, 0, receiveBytes.Length);

                    //显示消息内容
                    AddItemToListBox(string.Format("{0}:{1}", remoteIpEndPoint, message));


                    // 处理消息数据
                    string[] splitString = message.Split(',');

                    //解析用户端地址
                    string[] splitSubString = splitString[2].Split(':');

                    IPEndPoint clientIpEndpoint = new IPEndPoint(IPAddress.Parse(splitSubString[0]), int.Parse(splitSubString[1]));

                    switch (splitString[0])
                    {
                        //如果是登录
                        case "login":
                            User user = new User(splitString[1], clientIpEndpoint);
                            // 向在线用户列表添加新成员
                            userList.Add(user);
                            AddItemToListBox(string.Format("用户{0}{1}加入", user.GetName(), user.GetIPEndPoint()));
                            string sendString = "Accept" + tcpPort.ToString();
                            // 向客户端发送应答消息
                            SendToClient(user, sendString);
                            for (int i = 0; i < userList.Count; i++)
                            {
                                if (userList[i].GetName() != user.GetName())
                                {
                                    // 给在线的其他用户发送广播消息
                                    // 通知有新用户加入
                                    SendToClient(userList[i],message);
                                }
                            }
                            AddItemToListBox(string.Format("广播：[{0}]", message));
                            break;
                        case "logout":
                            for (int i=0; i< userList.Count;i++)
                            {
                                if(userList[i].GetName() == splitString[1])
                                {
                                    AddItemToListBox(string.Format("用户{0}{1}退出", userList[i].GetName(), userList[i].GetIPEndPoint()));
                                    userList.RemoveAt(i);
                                }
                            }

                            for (int i = 0; i < userList.Count; i++)
                            {
                                //广播注销消息
                                SendToClient(userList[i], message);
                            }
                            AddItemToListBox(string.Format("广播[{0}]",message));

                            break;
                    }
                }
                catch
                {
                    // 发生异常退出循环
                    break;
                }
            }
        }

        /// <summary>
        /// 向客户端发送消息
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        private void SendToClient(User user, string message)
        {
            // 匿名发送
            sendUdpClient = new UdpClient(0);
            byte[] sendBytes = Encoding.Unicode.GetBytes(message);
            IPEndPoint remoteIpEndPoint = user.GetIPEndPoint();
            sendUdpClient.Send(sendBytes, sendBytes.Length, remoteIpEndPoint);
            sendUdpClient.Close();
        }

        private void StopServerButton_Click(object sender, EventArgs e)
        {
            tcpListener.Stop();
            receiveUdpClient.Close();
            StartServerButton.Enabled = true;
            StopServerButton.Enabled = false;
        }

        private void LemonChatServerIndexForm_Load(object sender, EventArgs e)
        {

        }
    }
}
