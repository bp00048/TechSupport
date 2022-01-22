using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    
  
    public partial class MainForm : Form
    {
        bool logOut;
        private readonly IncidentController incidentController;
        readonly LoginForm currentLogIn;

        /// <summary>
        /// Main form of the application.
        /// Accepts a LoginForm to store and display the user's username.
        /// Displays an incidents list and allows the user to add 
        /// or search for an incident.
        /// </summary>
        public MainForm(LoginForm newLogin)
        {
            
            InitializeComponent();
            currentLogIn = newLogin;
            this.incidentController = new IncidentController();
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

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            this.RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.incidentController.GetIncidentList();
            
        }

        private void addIncidentButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form addIncidentDialog = new AddIncidentDialog();
            DialogResult result = addIncidentDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.RefreshDataGrid();
                this.Show();
            }
            else if (result == DialogResult.Cancel)
            {
                this.Show();
                MessageBox.Show("Add incident cancelled.");
       
            }
        }

        private void searchIncidentButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form searchIncidentDialog = new SearchIncidentDialog();
            DialogResult result = searchIncidentDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                this.Show();
            }
           
        }
    }
}
