
using System.Windows.Forms;

namespace TechSupport.UserControls
{
    public partial class ReportUserControl : UserControl
    {
        public ReportUserControl()
        {
            InitializeComponent();
        }

      private void Report_Load(object sender, System.EventArgs e)
        {
            this.LoadReport();
        }

      public void LoadReport()
        {
            this.openIncidentsByTechniciansTableAdapter.Fill(this.techSupportDataSetForIncidentsByTechnicians.OpenIncidentsByTechnicians);

            this.reportViewer.RefreshReport();
        }
    }
}
