
using System.Windows.Forms;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User control that holds the report viewer for the open incidents by technicians report.
    /// </summary>
    public partial class ReportUserControl : UserControl
    {
        /// <summary>
        /// Controller for Report User control.
        /// </summary>
        public ReportUserControl()
        {
            InitializeComponent();
        }

      private void Report_Load(object sender, System.EventArgs e)
        {
            this.LoadReport();
        }

        /// <summary>
        /// Calls the tableadapter's fill function that has a select statement calling upon all incidents with a technician assigned that are not closed.
        /// Also refreshes the report.
        /// </summary>
      public void LoadReport()
        {
            this.openIncidentsByTechniciansTableAdapter.Fill(this.techSupportDataSetForIncidentsByTechnicians.OpenIncidentsByTechnicians);

            this.reportViewer.RefreshReport();
        }
    }
}
