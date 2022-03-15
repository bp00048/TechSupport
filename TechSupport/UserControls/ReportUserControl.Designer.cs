
namespace TechSupport.UserControls
{
    partial class ReportUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.techSupportDataSetForIncidentsByTechnicians = new TechSupport.TechSupportDataSetForIncidentsByTechnicians();
            this.openIncidentsByTechniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openIncidentsByTechniciansTableAdapter = new TechSupport.TechSupportDataSetForIncidentsByTechniciansTableAdapters.OpenIncidentsByTechniciansTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSetForIncidentsByTechnicians)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsByTechniciansBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OpenIncidentsByTechnicianReport";
            reportDataSource1.Value = this.openIncidentsByTechniciansBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "TechSupport.UserControls.OpenIncidentsByTechnicianReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(427, 300);
            this.reportViewer.TabIndex = 0;
            // 
            // techSupportDataSetForIncidentsByTechnicians
            // 
            this.techSupportDataSetForIncidentsByTechnicians.DataSetName = "TechSupportDataSetForIncidentsByTechnicians";
            this.techSupportDataSetForIncidentsByTechnicians.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openIncidentsByTechniciansBindingSource
            // 
            this.openIncidentsByTechniciansBindingSource.DataMember = "OpenIncidentsByTechnicians";
            this.openIncidentsByTechniciansBindingSource.DataSource = this.techSupportDataSetForIncidentsByTechnicians;
            // 
            // openIncidentsByTechniciansTableAdapter
            // 
            this.openIncidentsByTechniciansTableAdapter.ClearBeforeFill = true;
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(427, 300);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSetForIncidentsByTechnicians)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsByTechniciansBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource openIncidentsByTechniciansBindingSource;
        private TechSupportDataSetForIncidentsByTechnicians techSupportDataSetForIncidentsByTechnicians;
        private TechSupportDataSetForIncidentsByTechniciansTableAdapters.OpenIncidentsByTechniciansTableAdapter openIncidentsByTechniciansTableAdapter;
    }
}
