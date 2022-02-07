using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// This class is a user control that adds incidents to the in-memory list.
    /// </summary>
    public partial class AddIncidentUserControl : UserControl
    {


        private readonly IncidentController incidentController;
        /// <summary>
        /// Constructor that intializes the component and a new Incident controller object.
        /// </summary>
        public AddIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();

        }
        /// <summary>
        /// Triggered by the user clicking the add button. It attempts to submit the inputted text as the title, description and customerID. If 
        /// successful, "incident is added!" alerts the user and the incident is added. If not, a message box appears indicating the issue and the incident
        /// is not added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIncidentButton_Click(object sender, System.EventArgs e)
        {

            try
            {
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;
                var customerID = int.Parse(this.customerIDTextBox.Text);

                this.incidentController.Add(new Model.Incident(title, description, customerID));
                this.messageLabel.Text = "Incident is added!";
            }

            catch (FormatException)
            {
                MessageBox.Show("Customer ID must be a number \n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.titleTextBox.Clear();
            this.descriptionTextBox.Clear();
            this.customerIDTextBox.Clear();
            this.messageLabel.Text = "";
        }

        private void TextBoxChanged(object sender, EventArgs e)
        {
            this.messageLabel.Text = "";
        }
    }
}

    