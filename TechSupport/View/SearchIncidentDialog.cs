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
                this.RefreshDataGrid(customerID);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input \n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

     
        }

        private void RefreshDataGrid(int customerID)
        {
            this.searchResultDataGridView.DataSource = null;
            this.searchResultDataGridView.DataSource = this.incidentController.GetIncidentList(customerID);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
