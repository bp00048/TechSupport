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
        //The Username string stores the username of the potential user. 
        //It is references in the MainForm so it is public.
        public string Username { get; set; }
        string password;
        public LoginForm()
        {
            InitializeComponent();

      
        }

        //The credentials (username "Jane" and password "test1234") are checked and case sensitize. The true or false is returned.
        private Boolean CheckCredentials()
        {
            Username = usernameTextbox.Text;
            password = passwordTextbox.Text;

            return (String.Equals(Username, "Jane") && String.Equals(password, "test1234"));

        }

  
        //Once the login is successful it hides the login form and creates a new MainForm to show. 
        //If the login is not successful, an error message is displayed.
        private void LoginSubmit(object sender, EventArgs e)
        {
            if (CheckCredentials())
            {
                
                MainForm newMainForm = new MainForm(this);
                newMainForm.Show();
                this.Hide();
            
            } else
            {
                errorMessage.ForeColor = Color.Red;
                errorMessage.Text = "Invalid username or password.";
            }
        }


        //Clears the username and password of the respective textboxes
        //for the user to log in again and makes the LoginForm appear.

        public void LogOut()
        {
            usernameTextbox.Clear();
            passwordTextbox.Clear();
            this.Show();
        }

        //Removes the error message when the user begins retyping in either username or password textbox.
        private void UserInputEntered(object sender, EventArgs e)
        {
            errorMessage.Text = "";
        }
    }

}
