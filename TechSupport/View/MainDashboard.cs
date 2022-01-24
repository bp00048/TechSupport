using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class MainDashboard : Form
    {
      

        private readonly IncidentController incidentController;
        bool logOut;
        readonly LoginForm currentLogIn;
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
    }
}

