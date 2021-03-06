using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechSupport.View
{
   /// <summary>
   /// This class displays a login form for the user to log in with designated username and password.
   /// </summary>
    public partial class LoginForm : Form
        
    {

        /// <summary>
        /// Displays login information for user to input credentials. 
        /// When criteria is met, MainForm is launched and Login hides.
        /// </summary>
        public string Username { get; set; }
        string password;
        public LoginForm()
        {
            InitializeComponent();

      
        }

      
        private Boolean CheckCredentials()
        {
            Username = usernameTextbox.Text;
            password = passwordTextbox.Text;

            return (String.Equals(Username, "Jane") && String.Equals(password, "test1234"));

        }

  
        private void LoginSubmit(object sender, EventArgs e)
        {
            if (CheckCredentials())
            {
                
                MainDashboard newMainDashboard = new MainDashboard(this);
                
                newMainDashboard.Show();
                this.Hide();
            
            } else
            {
                errorMessage.ForeColor = Color.Red;
                errorMessage.Text = "Invalid username or password.";
            }
        }

        /// <summary>
        /// Clears the username and password of the respective 
        /// textboxes for the user to log in again and make the LoginForm appear.
        /// </summary>

        public void LogOut()
        {
            usernameTextbox.Clear();
            passwordTextbox.Clear();
            this.Show();
        }

        
        private void UserInputEntered(object sender, EventArgs e)
        {
            errorMessage.Text = "";
        }

    }

}
