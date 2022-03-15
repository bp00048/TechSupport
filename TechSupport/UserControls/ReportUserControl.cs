
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
            // TODO: This line of code loads data into the 'techSupportDataSetForIncidentsByTechnicians.OpenIncidentsByTechnicians' table. You can move, or remove it, as needed.
            this.openIncidentsByTechniciansTableAdapter.Fill(this.techSupportDataSetForIncidentsByTechnicians.OpenIncidentsByTechnicians);

            this.reportViewer.RefreshReport();
        }

    }
}
