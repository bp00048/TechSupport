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
    public partial class LoginForm : Form
        
    {
        string username;
        string password;
        public LoginForm()
        {
            InitializeComponent();
      
        }

        private Boolean CheckCredentials()
        {
            username = usernameTextbox.Text;
            password = passwordTextbox.Text;

            return (String.Equals(username, "Jane") && String.Equals(password, "test1234"));

        }
      
        public string GetUsername()
        {
            return username;
        }
  
        private void LoginSubmit(object sender, EventArgs e)
        {
            if (CheckCredentials())
            {
                Program.LoginSuccess = true;
                MainForm newMainForm = new MainForm(this);
                newMainForm.Show();
                this.Hide();
            
            } else
            {
                errorMessage.ForeColor = Color.Red;
                errorMessage.Text = "Invalid username or password.";
            }
        }


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

        private void loginSubmit(object sender, EventArgs e)
        {

        }
    }

}
