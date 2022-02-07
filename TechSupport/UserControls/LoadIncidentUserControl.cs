using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// This class displays the current in-memory incident list and updates when loaded.
    /// </summary>

    public partial class LoadIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// Initializes the component, a new incidentcontroller object and a load event handler. It also refreshes the datagrid
        /// to display an up-to-date list.
        /// </summary>
        public LoadIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
            this.Load += new System.EventHandler(LoadIncidentUserControl_Load);
            this.RefreshDataGrid();

        }

        private void RefreshDataGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.incidentController.GetIncidentList();

        }

        private void LoadIncidentUserControl_Load(object sender, EventArgs e)
        {
            this.RefreshDataGrid();
        }

   
    }
}
