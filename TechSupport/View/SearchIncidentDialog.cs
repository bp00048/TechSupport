using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{

    /// <summary>
    /// This class shows a dialog box containing a search function that will display the 
    /// search results including the determined customerId.
    /// </summary>
    public partial class SearchIncidentDialog : Form
    {
        private readonly IncidentController incidentController;
        public SearchIncidentDialog()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
            this.FormClosed += new FormClosedEventHandler(SearchIncidentDialog_FormClosed);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {

                var customerID = int.Parse(this.searchTextBox.Text);
                this.RefreshDataGrid(customerID);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input \n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

     
        }

        private void SearchIncidentDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
