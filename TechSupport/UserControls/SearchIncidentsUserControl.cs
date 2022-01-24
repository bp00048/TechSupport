using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class SearchIncidentsUserControl : UserControl
    {

        private readonly IncidentController incidentController;
        public SearchIncidentsUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
        }



        private void RefreshDataGrid(int customerID)
        {
            this.searchResultDataGridView.DataSource = null;
            this.searchResultDataGridView.DataSource = this.incidentController.GetIncidentList(customerID);

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

    }
}
