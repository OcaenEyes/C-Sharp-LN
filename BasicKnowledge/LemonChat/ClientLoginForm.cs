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

namespace LemonChat
{
    public partial class ClientLoginForm : Form
    {
        //服务器端口
        int port;
        // 定义变量
        private UdpClient sendUdpClient;
        private UdpClient receiveUdpClient;
        private IPEndPoint clientIpEndPoint;
        private TcpClient tcpClient;
        private NetworkStream networkStream;
        private BinaryReader binaryReader;
        private string userListString;


        public ClientLoginForm()
        {
            InitializeComponent();
            IPAddress[] localIp = Dns.GetHostAddresses("");
            ServerIpTextBox.Text = localIp[1].ToString();
            LocalIpTextBox.Text = localIp[1].ToString();

            // 随机指定本地端口
            Random random = new Random();
            port = random.Next(1024, 65500);
            LocalPortTextBox.Text = port.ToString();

            // 随机生成用户名
            Random random1 = new Random((int)DateTime.Now.Ticks);
            UserNameTextBox.Text = "user" + random1.Next(100,999);
            LogoutButton.Enabled = false;
        }


        private void ReceiveMessage()
        {
            IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                try
                {
                    byte[] receiveBytes = receiveUdpClient.Receive(ref remoteIPEndPoint);
                    string message = Encoding.Unicode.GetString(receiveBytes, 0, receiveBytes.Length);

                    //处理消息
                    string[] splitString = message.Split(',');

                    switch (splitString[0])
                    {
                        case "Accept":
                            try
                                {
                                    tcpClient = new TcpClient();
                                    tcpClient.Connect(remoteIPEndPoint.Address, int.Parse(splitString[1]));
                                    if (tcpClient != null)
                                    {
                                        //表示连接成功
                                        networkStream = tcpClient.GetStream();
                                        binaryReader = new BinaryReader(networkStream);
                                    }
                                }
                            catch
                                {
                                    MessageBox.Show("连接失败","异常");
                                }
                            Thread getUserListThread = new Thread(GetUserList);
                            getUserListThread.Start();
                            break;

                        case "login":
                            string userItem = splitString[1] + "," + splitString[2];

                            break;

                        case "logout":
                            
                            break;

                        case "talk":
                            break;
                    }

                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        private void GetUserList()
        {
            while (true)
            {
                userListString = null;
                try
                {
                    userListString = binaryReader.ReadString();
                    if (userListString.EndsWith("end"))
                    {
                        string[] splitString = userListString.Split(',');
                        for (int i = 0; i < splitString.Length - 1; i++)
                        {
                            AddItemToListView(splitString[i]);
                        }
                        binaryReader.Close();
                        tcpClient.Close();
                        break;
                    }
                }
                catch
                {
                    break;
                }
            }
        }

        // 用委托机制来操作界面上控件
        private delegate void AddItemToListViewDelegate(string str);
        private void AddItemToListView(string userinfo)
        {
            if (OnlineUserListView.InvokeRequired)
            {
                AddItemToListViewDelegate addItemToListViewDelegate = AddItemToListView;
                OnlineUserListView.Invoke(addItemToListViewDelegate, userinfo);
            }
            else
            {
                string[] splitSting = userinfo.Split(',');
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems.Add(splitSting[0]);
                listViewItem.SubItems.Add(splitSting[1]);
                OnlineUserListView.Items.Add(listViewItem);
            }
        }


        private delegate void RemoveItemFromListViewDelegate(string str);
 
        // 登录服务器
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //创建接收套接字
            IPAddress clientIP = IPAddress.Parse(LocalIpTextBox.Text);
            clientIpEndPoint = new IPEndPoint(clientIP, int.Parse(LocalPortTextBox.Text));
            receiveUdpClient = new UdpClient(clientIpEndPoint);

            //启动接收线程
            Thread receiveThread = new Thread(ReceiveMessage);
            receiveThread.Start();

            // 匿名发送
            sendUdpClient = new UdpClient();

            //启动发送线程
            Thread sendThread = new Thread(SendMessage);
            sendThread.Start(string.Format("login,{0},{1}", UserNameTextBox.Text, clientIpEndPoint));

            this.Text = UserNameTextBox.Text;



        }

        private void SendMessage(object obj)
        {
            string message = obj as string;
            byte[] sendbytes = Encoding.Unicode.GetBytes(message);
            IPAddress remoteIp = IPAddress.Parse(ServerIpTextBox.Text);
            IPEndPoint remoteIPEndPoint = new IPEndPoint(remoteIp, int.Parse(ServerPortTextBox.Text));
            sendUdpClient.Send(sendbytes, sendbytes.Length, remoteIPEndPoint);
            sendUdpClient.Close();
        }
    }
}
