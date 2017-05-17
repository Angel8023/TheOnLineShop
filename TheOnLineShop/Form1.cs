using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheOnLineShop
{
    public partial class Form1 : Form
    {
        private static bool islogined = false;
        private static string username;
        private static string account;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void pleaseLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!islogined)
            {
                LoginForm loginform = new LoginForm();
                loginform.Show();
            }   
        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm regform = new RegisterForm();
            regform.Show();
        }

    }
}
