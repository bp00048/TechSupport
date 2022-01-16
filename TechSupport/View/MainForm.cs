using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class MainForm : Form
    {
        bool logOut;
        LoginForm currentLogIn;
    
        public MainForm(LoginForm newLogin)
        {
            
            InitializeComponent();
            currentLogIn = newLogin;
            currentUsernameLabel.Text = currentLogIn.GetUsername();
            logOut = false;

        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logOut = true;
            currentLogIn.LogOut();
            this.Close();
        }

        private void MainClosing(object sender, FormClosingEventArgs e)
        {
            if (!logOut)
            {
                Application.Exit();
            }
        }
    }
}
