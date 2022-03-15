using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// This class is the main dashboard that displays the username and a logout button. It also displays multiple tab controls for Adding, Displaying and 
    /// Loading incidents, as well as displaying the Open Incidents in the tech support database.
    /// </summary>
    public partial class MainDashboard : Form
    {
        IncidentController inController = new IncidentController();
   
        private readonly IncidentController incidentController;
        bool logOut;
        readonly LoginForm currentLogIn;
        /// <summary>
        /// Initializes the component and uses the Login form to close the application in the event of Logout or closing the window.
        /// </summary>
        /// <param name="newLogin"></param>
        public MainDashboard(LoginForm newLogin)
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
            currentLogIn = newLogin;
            this.currentUsernameLabel.Text = currentLogIn.Username;
            this.FormClosed += new FormClosedEventHandler(MainDashboard_FormClosed);
            logOut = false;
        }


        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logOut)
            {
                Application.Exit();
            }
        }



        private void DisplayOpenIncidents_Load(object sender, System.EventArgs e)
        {
            displayOpenIncidentsUserControl.DisplayOpenIncidents();
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void Load_Report(object sender, System.EventArgs e)
        {
            this.ReportUserControl.LoadReport();
        }
    }
}

