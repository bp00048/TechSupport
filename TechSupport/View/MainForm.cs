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
    //This class passes the LoginForm through its constructor to build its username data. 
    public partial class MainForm : Form
    {
        bool logOut;
        readonly LoginForm currentLogIn;
    
        public MainForm(LoginForm newLogin)
        {
            
            InitializeComponent();
            currentLogIn = newLogin;
            currentUsernameLabel.Text = currentLogIn.Username;
            logOut = false;

        }

        //The form closes instead of hides to avoid multiple instances of the form running in the background if the user logs in again.
        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logOut = true;
            currentLogIn.LogOut();
            this.Close();
        }

        //logOut bool stops the application from exiting when user selects log out instead of clicking the x.
        private void MainClosing(object sender, FormClosingEventArgs e)
        {
            if (!logOut)
            {
                Application.Exit();
            }
        }
    }
}
