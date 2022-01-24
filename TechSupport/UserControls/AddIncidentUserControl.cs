using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class AddIncidentUserControl : UserControl
    {


        private readonly IncidentController incidentController;

        public AddIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();

        }

        private void addIncidentButton_Click(object sender, System.EventArgs e)
        {

            try
            {
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;
                var customerID = int.Parse(this.customerIDTextBox.Text);

                this.incidentController.Add(new Model.Incident(title, description, customerID));
                this.messageLabel.Text = "Incident is added!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input \n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.titleTextBox.Clear();
            this.descriptionTextBox.Clear();
            this.customerIDTextBox.Clear();
            this.messageLabel.Text = "";
        }
    }
}

    