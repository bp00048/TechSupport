
namespace TechSupport.View
{
    partial class MainDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openIncidentsByTechniciansBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.techSupportDataSetForIncidentsByTechniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupportDataSetForIncidentsByTechnicians = new TechSupport.TechSupportDataSetForIncidentsByTechnicians();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.AddIncidentTab = new System.Windows.Forms.TabPage();
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.UpdateTab = new System.Windows.Forms.TabPage();
            this.updateUserControl1 = new TechSupport.UserControls.UpdateUserControl();
            this.DisplayOpenIncidentsTab = new System.Windows.Forms.TabPage();
            this.displayOpenIncidentsUserControl = new TechSupport.UserControls.DisplayOpenIncidentsUserControl();
            this.ViewIncidentsByTechnicianTab = new System.Windows.Forms.TabPage();
            this.DisplayIncidentsByTechnicianUserControl = new TechSupport.UserControls.DisplayIncidentsByTechnicianUserControl();
            this.ReportTab = new System.Windows.Forms.TabPage();
            this.reportUserControl1 = new TechSupport.UserControls.ReportUserControl();
            this.ReportUserControl = new TechSupport.UserControls.ReportUserControl();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.currentUsernameLabel = new System.Windows.Forms.Label();
            this.openIncidentsByTechniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openIncidentsByTechniciansTableAdapter = new TechSupport.TechSupportDataSetForIncidentsByTechniciansTableAdapters.OpenIncidentsByTechniciansTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsByTechniciansBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSetForIncidentsByTechniciansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSetForIncidentsByTechnicians)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.AddIncidentTab.SuspendLayout();
            this.UpdateTab.SuspendLayout();
            this.DisplayOpenIncidentsTab.SuspendLayout();
            this.ViewIncidentsByTechnicianTab.SuspendLayout();
            this.ReportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsByTechniciansBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openIncidentsByTechniciansBindingSource1
            // 
            this.openIncidentsByTechniciansBindingSource1.DataMember = "OpenIncidentsByTechnicians";
            this.openIncidentsByTechniciansBindingSource1.DataSource = this.techSupportDataSetForIncidentsByTechniciansBindingSource;
            // 
            // techSupportDataSetForIncidentsByTechniciansBindingSource
            // 
            this.techSupportDataSetForIncidentsByTechniciansBindingSource.DataSource = this.techSupportDataSetForIncidentsByTechnicians;
            this.techSupportDataSetForIncidentsByTechniciansBindingSource.Position = 0;
            // 
            // techSupportDataSetForIncidentsByTechnicians
            // 
            this.techSupportDataSetForIncidentsByTechnicians.DataSetName = "TechSupportDataSetForIncidentsByTechnicians";
            this.techSupportDataSetForIncidentsByTechnicians.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.AddIncidentTab);
            this.mainTabControl.Controls.Add(this.UpdateTab);
            this.mainTabControl.Controls.Add(this.DisplayOpenIncidentsTab);
            this.mainTabControl.Controls.Add(this.ViewIncidentsByTechnicianTab);
            this.mainTabControl.Controls.Add(this.ReportTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 73);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(656, 552);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.DisplayOpenIncidents_Load);
            // 
            // AddIncidentTab
            // 
            this.AddIncidentTab.Controls.Add(this.addIncidentUserControl1);
            this.AddIncidentTab.Location = new System.Drawing.Point(4, 33);
            this.AddIncidentTab.Margin = new System.Windows.Forms.Padding(2);
            this.AddIncidentTab.Name = "AddIncidentTab";
            this.AddIncidentTab.Padding = new System.Windows.Forms.Padding(2);
            this.AddIncidentTab.Size = new System.Drawing.Size(648, 515);
            this.AddIncidentTab.TabIndex = 0;
            this.AddIncidentTab.Text = "Add Incident";
            this.AddIncidentTab.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addIncidentUserControl1.Location = new System.Drawing.Point(-3, 0);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.addIncidentUserControl1.MaximumSize = new System.Drawing.Size(733, 508);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(653, 471);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // UpdateTab
            // 
            this.UpdateTab.Controls.Add(this.updateUserControl1);
            this.UpdateTab.Location = new System.Drawing.Point(4, 33);
            this.UpdateTab.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateTab.Name = "UpdateTab";
            this.UpdateTab.Padding = new System.Windows.Forms.Padding(2);
            this.UpdateTab.Size = new System.Drawing.Size(648, 515);
            this.UpdateTab.TabIndex = 1;
            this.UpdateTab.Text = "Update";
            this.UpdateTab.UseVisualStyleBackColor = true;
            // 
            // updateUserControl1
            // 
            this.updateUserControl1.Location = new System.Drawing.Point(-3, 3);
            this.updateUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateUserControl1.Name = "updateUserControl1";
            this.updateUserControl1.Size = new System.Drawing.Size(651, 523);
            this.updateUserControl1.TabIndex = 0;
            // 
            // DisplayOpenIncidentsTab
            // 
            this.DisplayOpenIncidentsTab.Controls.Add(this.displayOpenIncidentsUserControl);
            this.DisplayOpenIncidentsTab.Location = new System.Drawing.Point(4, 33);
            this.DisplayOpenIncidentsTab.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayOpenIncidentsTab.Name = "DisplayOpenIncidentsTab";
            this.DisplayOpenIncidentsTab.Padding = new System.Windows.Forms.Padding(2);
            this.DisplayOpenIncidentsTab.Size = new System.Drawing.Size(648, 515);
            this.DisplayOpenIncidentsTab.TabIndex = 3;
            this.DisplayOpenIncidentsTab.Text = "DisplayOpenIncidents";
            this.DisplayOpenIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // displayOpenIncidentsUserControl
            // 
            this.displayOpenIncidentsUserControl.Location = new System.Drawing.Point(4, 12);
            this.displayOpenIncidentsUserControl.Margin = new System.Windows.Forms.Padding(2);
            this.displayOpenIncidentsUserControl.Name = "displayOpenIncidentsUserControl";
            this.displayOpenIncidentsUserControl.Size = new System.Drawing.Size(641, 455);
            this.displayOpenIncidentsUserControl.TabIndex = 0;
            // 
            // ViewIncidentsByTechnicianTab
            // 
            this.ViewIncidentsByTechnicianTab.Controls.Add(this.DisplayIncidentsByTechnicianUserControl);
            this.ViewIncidentsByTechnicianTab.Location = new System.Drawing.Point(4, 33);
            this.ViewIncidentsByTechnicianTab.Margin = new System.Windows.Forms.Padding(2);
            this.ViewIncidentsByTechnicianTab.Name = "ViewIncidentsByTechnicianTab";
            this.ViewIncidentsByTechnicianTab.Padding = new System.Windows.Forms.Padding(2);
            this.ViewIncidentsByTechnicianTab.Size = new System.Drawing.Size(648, 515);
            this.ViewIncidentsByTechnicianTab.TabIndex = 4;
            this.ViewIncidentsByTechnicianTab.Text = "View Incidents by Technician";
            this.ViewIncidentsByTechnicianTab.UseVisualStyleBackColor = true;
            this.ViewIncidentsByTechnicianTab.Enter += new System.EventHandler(this.Enter_ViewIncidentsByTechnicians);
            // 
            // DisplayIncidentsByTechnicianUserControl
            // 
            this.DisplayIncidentsByTechnicianUserControl.Location = new System.Drawing.Point(11, -37);
            this.DisplayIncidentsByTechnicianUserControl.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayIncidentsByTechnicianUserControl.Name = "DisplayIncidentsByTechnicianUserControl";
            this.DisplayIncidentsByTechnicianUserControl.Size = new System.Drawing.Size(636, 546);
            this.DisplayIncidentsByTechnicianUserControl.TabIndex = 0;
            // 
            // ReportTab
            // 
            this.ReportTab.Controls.Add(this.reportUserControl1);
            this.ReportTab.Controls.Add(this.ReportUserControl);
            this.ReportTab.Location = new System.Drawing.Point(4, 33);
            this.ReportTab.Name = "ReportTab";
            this.ReportTab.Size = new System.Drawing.Size(648, 515);
            this.ReportTab.TabIndex = 5;
            this.ReportTab.Text = "Report";
            this.ReportTab.UseVisualStyleBackColor = true;
            this.ReportTab.Enter += new System.EventHandler(this.Enter_Report);
            // 
            // reportUserControl1
            // 
            this.reportUserControl1.Location = new System.Drawing.Point(11, 6);
            this.reportUserControl1.Margin = new System.Windows.Forms.Padding(6);
            this.reportUserControl1.Name = "reportUserControl1";
            this.reportUserControl1.Size = new System.Drawing.Size(626, 435);
            this.reportUserControl1.TabIndex = 1;
            // 
            // ReportUserControl
            // 
            this.ReportUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportUserControl.Location = new System.Drawing.Point(0, 0);
            this.ReportUserControl.Margin = new System.Windows.Forms.Padding(6);
            this.ReportUserControl.Name = "ReportUserControl";
            this.ReportUserControl.Size = new System.Drawing.Size(0, 0);
            this.ReportUserControl.TabIndex = 0;
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.Location = new System.Drawing.Point(552, 49);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(52, 17);
            this.logoutLabel.TabIndex = 1;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // currentUsernameLabel
            // 
            this.currentUsernameLabel.AutoSize = true;
            this.currentUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUsernameLabel.Location = new System.Drawing.Point(458, 19);
            this.currentUsernameLabel.Name = "currentUsernameLabel";
            this.currentUsernameLabel.Size = new System.Drawing.Size(0, 17);
            this.currentUsernameLabel.TabIndex = 5;
            // 
            // openIncidentsByTechniciansBindingSource
            // 
            this.openIncidentsByTechniciansBindingSource.DataMember = "OpenIncidentsByTechnicians";
            this.openIncidentsByTechniciansBindingSource.DataSource = this.techSupportDataSetForIncidentsByTechniciansBindingSource;
            // 
            // openIncidentsByTechniciansTableAdapter
            // 
            this.openIncidentsByTechniciansTableAdapter.ClearBeforeFill = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 625);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.currentUsernameLabel);
            this.Controls.Add(this.logoutLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsByTechniciansBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSetForIncidentsByTechniciansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSetForIncidentsByTechnicians)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.AddIncidentTab.ResumeLayout(false);
            this.UpdateTab.ResumeLayout(false);
            this.DisplayOpenIncidentsTab.ResumeLayout(false);
            this.ViewIncidentsByTechnicianTab.ResumeLayout(false);
            this.ReportTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsByTechniciansBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage AddIncidentTab;
        private System.Windows.Forms.TabPage UpdateTab;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.Label currentUsernameLabel;
        private System.Windows.Forms.TabPage DisplayOpenIncidentsTab;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
        private UserControls.UpdateUserControl updateUserControl1;
        private System.Windows.Forms.TabPage ViewIncidentsByTechnicianTab;
        private UserControls.DisplayOpenIncidentsUserControl displayOpenIncidentsUserControl;
        private UserControls.DisplayIncidentsByTechnicianUserControl DisplayIncidentsByTechnicianUserControl;
        private System.Windows.Forms.TabPage ReportTab;
        private TechSupportDataSetForIncidentsByTechnicians techSupportDataSetForIncidentsByTechnicians;
        private System.Windows.Forms.BindingSource techSupportDataSetForIncidentsByTechniciansBindingSource;
        private System.Windows.Forms.BindingSource openIncidentsByTechniciansBindingSource;
        private TechSupportDataSetForIncidentsByTechniciansTableAdapters.OpenIncidentsByTechniciansTableAdapter openIncidentsByTechniciansTableAdapter;
        private System.Windows.Forms.BindingSource openIncidentsByTechniciansBindingSource1;
        private UserControls.ReportUserControl ReportUserControl;
        private UserControls.ReportUserControl reportUserControl1;
    }
}