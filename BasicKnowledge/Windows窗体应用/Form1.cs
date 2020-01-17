using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows窗体应用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按钮一的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
            button1.Enabled = false;
        }

        /// <summary>
        /// 按钮二的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            TextContent.Visible = false;
            Save.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string uname = UnameTextBox.Text;
            string pass = PassTextBox.Text;

            if(uname =="gzy" && pass == "gzy")
            {
                MessageBox.Show("登录成功！");
                UnameTextBox.Visible = false;
                PassTextBox.Visible = false;
                UnameLabel.Visible = false;
                PassLabel.Visible = false;
                button3.Visible = false;
                TextContent.Visible = true;
                Save.Visible = true;
            }
            else
            {
                MessageBox.Show("登录失败 -_-");
                UnameTextBox.Text = "";
                UnameTextBox.Focus();
                PassTextBox.Text = "";
            }
        }

        /// <summary>
        /// 点击保存时，将内容保存下来
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            using (FileStream fileWrite = new FileStream(@"C:\Users\YSilhouette\Desktop\1.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = TextContent.Text;
                // 将字符串转为数组
                byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
                fileWrite.Write(buffer, 0, buffer.Length);
            }

            MessageBox.Show("保存成功");
        }

        // 窗口抖动
        private void button4_Click(object sender, EventArgs e)
        {
            Point p = button4.Location;
            MessageBox.Show(p.ToString());
            for (int i = 0; i < 200; i++) {
                this.Location = new Point(300, 140);
                this.Location = new Point(220, 80);
            }
        }
    }
}
