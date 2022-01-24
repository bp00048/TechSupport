using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{

    public partial class LoadIncidentUserControl : UserControl
    {
        private readonly IncidentController incidentController;

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
