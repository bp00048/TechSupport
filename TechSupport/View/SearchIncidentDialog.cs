using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class SearchIncidentDialog : Form
    {
        private readonly IncidentController incidentController;
        public SearchIncidentDialog()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
         
                var customerID = int.Parse(this.searchTextBox.Text);

                this.incidentController.Add(new Model.Incident(title, description, customerID));
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input \n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
