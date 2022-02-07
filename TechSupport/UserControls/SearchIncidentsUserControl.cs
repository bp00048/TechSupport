using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// This class searches through the in-memory incident list based on a customer id inputted by the user.
    /// </summary>
    public partial class SearchIncidentsUserControl : UserControl
    {

        private readonly IncidentController incidentController;
        /// <summary>
        /// initializes the component and a new incident controller.
        /// </summary>
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


        private void SearchButton_Click(object sender, EventArgs e)
        {

            try
            {

                var customerID = int.Parse(this.searchTextBox.Text);
                this.RefreshDataGrid(customerID);

            }
            catch (Exception)
            {
                MessageBox.Show("CustomerID must be a number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

    }
}
