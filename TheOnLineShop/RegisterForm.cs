using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TheOnLineShop
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = name.Text.Trim();
            string userAccount = account.Text.Trim();
            string userPassword = password.Text.Trim();
            string userPasswordPlus = passwordplus.Text.Trim();
            string mibao = mibaobox.Text.Trim();
            if (userName == "" || userAccount == "" || userPassword == "" || userPasswordPlus == "" || mibao =="") { 
                MessageBox.Show("别闹，先把信息填好");
            }
            else if (!userPassword.Equals(userPasswordPlus))
            {
                MessageBox.Show("两次密码输入不一致");
                password.Text = "";
                passwordplus.Text = "";
                password.Focus();
            }
            else
            {
                string result = "404";
                //添加网络传输
                byte[] receive = new byte[1024];
                IPAddress host = IPAddress.Parse("123.206.195.212");
                int port = 10000;
                IPEndPoint iep = new IPEndPoint(host, port);
                try
                {
                    Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    s.Connect(iep);
                    String str = "register\n"+"userName\n"+"userAccount\n"+"userPassword\n"+"mibao";  //填写传输字符串
                    //MessageBox.Show(str);
                    s.Send(Encoding.UTF8.GetBytes(str));

                    //接受回执信息
                    s.Receive(receive);
                    result = Encoding.UTF8.GetString(receive);
                }
                catch (Exception){
                    MessageBox.Show("网络连接失败！");
                }
                //接受传输结果
                switch (result)
                {
                    case "ok":
                        MessageBox.Show("注册成功！");
                        Form1 form1 = new Form1();
                        //form1.setData(userAccount, userPassword);
                        form1.Show();
                        this.Close();
                        break;
                    case "exist":
                        MessageBox.Show("该用户已存在！");
                        account.Text = "";
                        account.Focus();
                        break;
                }
            }
        }
    }
}
