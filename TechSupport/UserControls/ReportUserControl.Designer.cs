
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
            this.openIncidentsByTechniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupportDataSetForIncidentsByTechnicians = new TechSupport.TechSupportDataSetForIncidentsByTechnicians();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.openIncidentsByTechniciansTableAdapter = new TechSupport.TechSupportDataSetForIncidentsByTechniciansTableAdapters.OpenIncidentsByTechniciansTableAdapter();
            this.openIncidentsByTechniciansBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsByTechniciansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSetForIncidentsByTechnicians)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsByTechniciansBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // openIncidentsByTechniciansBindingSource
            // 
            this.openIncidentsByTechniciansBindingSource.DataMember = "OpenIncidentsByTechnicians";
            this.openIncidentsByTechniciansBindingSource.DataSource = this.techSupportDataSetForIncidentsByTechnicians;
            // 
            // techSupportDataSetForIncidentsByTechnicians
            // 
            this.techSupportDataSetForIncidentsByTechnicians.DataSetName = "TechSupportDataSetForIncidentsByTechnicians";
            this.techSupportDataSetForIncidentsByTechnicians.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OpenIncidentsByTechnicianReport";
            reportDataSource1.Value = this.openIncidentsByTechniciansBindingSource1;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "TechSupport.UserControls.OpenIncidentsByTechnicianReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(427, 300);
            this.reportViewer.TabIndex = 0;
            // 
            // openIncidentsByTechniciansTableAdapter
            // 
            this.openIncidentsByTechniciansTableAdapter.ClearBeforeFill = true;
            // 
            // openIncidentsByTechniciansBindingSource1
            // 
            this.openIncidentsByTechniciansBindingSource1.DataMember = "OpenIncidentsByTechnicians";
            this.openIncidentsByTechniciansBindingSource1.DataSource = this.techSupportDataSetForIncidentsByTechnicians;
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(427, 300);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsByTechniciansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSetForIncidentsByTechnicians)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsByTechniciansBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource openIncidentsByTechniciansBindingSource;
        private TechSupportDataSetForIncidentsByTechnicians techSupportDataSetForIncidentsByTechnicians;
        private TechSupportDataSetForIncidentsByTechniciansTableAdapters.OpenIncidentsByTechniciansTableAdapter openIncidentsByTechniciansTableAdapter;
        private System.Windows.Forms.BindingSource openIncidentsByTechniciansBindingSource1;
    }
}
