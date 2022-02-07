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
        /// <summary>
        /// Constructor. Initializes a new incidentcontroller and event handler for closing the window and application.
        /// </summary>
        public SearchIncidentDialog()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
            this.FormClosed += new FormClosedEventHandler(SearchIncidentDialog_FormClosed);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
