using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// Main form of the application. Accepts a LoginForm to store the user's username.
    /// </summary>
  
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

        
       
        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
