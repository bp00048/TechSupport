
using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class AddIncidentDialog : Form
    {
        private readonly IncidentController incidentController;
        
        public AddIncidentDialog()
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
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input \n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
