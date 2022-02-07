
using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// This class represents the Add Incident Dialog. The user can fill out a form involving the title, description and customerid
    /// associated with the incident. If all criteria is met, it is added to the list and the user is brought back to the main form
    /// with the updated list. If not, the user is alerted of a failed addition.
    /// </summary>
    public partial class AddIncidentDialog : Form
    {
        private readonly IncidentController incidentController;
        /// <summary>
        /// Constructor. Initializes the component and a new incident controller.
        /// </summary>
        public AddIncidentDialog()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void AddIncidentButton_Click(object sender, System.EventArgs e)
        {

            try
            {
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;
                var customerID = int.Parse(this.customerIDTextBox.Text);

                this.incidentController.Add(new Model.Incident(title, description, customerID));
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input \n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
