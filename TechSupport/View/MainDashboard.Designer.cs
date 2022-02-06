
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.AddIncidentTab = new System.Windows.Forms.TabPage();
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.LoadIncidentsTab = new System.Windows.Forms.TabPage();
            this.loadIncidentUserControl1 = new TechSupport.UserControls.LoadIncidentUserControl();
            this.SearchIncidentsTab = new System.Windows.Forms.TabPage();
            this.searchIncidentsUserControl1 = new TechSupport.UserControls.SearchIncidentsUserControl();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.currentUsernameLabel = new System.Windows.Forms.Label();
            this.DisplayOpenIncidentsTab = new System.Windows.Forms.TabPage();
            this.mainTabControl.SuspendLayout();
            this.AddIncidentTab.SuspendLayout();
            this.LoadIncidentsTab.SuspendLayout();
            this.SearchIncidentsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.AddIncidentTab);
            this.mainTabControl.Controls.Add(this.LoadIncidentsTab);
            this.mainTabControl.Controls.Add(this.SearchIncidentsTab);
            this.mainTabControl.Controls.Add(this.DisplayOpenIncidentsTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 99);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(932, 649);
            this.mainTabControl.TabIndex = 0;
            // 
            // AddIncidentTab
            // 
            this.AddIncidentTab.Controls.Add(this.addIncidentUserControl1);
            this.AddIncidentTab.Location = new System.Drawing.Point(4, 41);
            this.AddIncidentTab.Name = "AddIncidentTab";
            this.AddIncidentTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddIncidentTab.Size = new System.Drawing.Size(924, 604);
            this.AddIncidentTab.TabIndex = 0;
            this.AddIncidentTab.Text = "Add Incident";
            this.AddIncidentTab.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addIncidentUserControl1.Location = new System.Drawing.Point(74, 37);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.addIncidentUserControl1.MaximumSize = new System.Drawing.Size(1244, 800);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(763, 499);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // LoadIncidentsTab
            // 
            this.LoadIncidentsTab.Controls.Add(this.loadIncidentUserControl1);
            this.LoadIncidentsTab.Location = new System.Drawing.Point(4, 41);
            this.LoadIncidentsTab.Name = "LoadIncidentsTab";
            this.LoadIncidentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoadIncidentsTab.Size = new System.Drawing.Size(924, 604);
            this.LoadIncidentsTab.TabIndex = 1;
            this.LoadIncidentsTab.Text = "Load Incidents";
            this.LoadIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // loadIncidentUserControl1
            // 
            this.loadIncidentUserControl1.Location = new System.Drawing.Point(12, 50);
            this.loadIncidentUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.loadIncidentUserControl1.Name = "loadIncidentUserControl1";
            this.loadIncidentUserControl1.Size = new System.Drawing.Size(880, 529);
            this.loadIncidentUserControl1.TabIndex = 0;
            // 
            // SearchIncidentsTab
            // 
            this.SearchIncidentsTab.Controls.Add(this.searchIncidentsUserControl1);
            this.SearchIncidentsTab.Location = new System.Drawing.Point(4, 41);
            this.SearchIncidentsTab.Name = "SearchIncidentsTab";
            this.SearchIncidentsTab.Size = new System.Drawing.Size(924, 604);
            this.SearchIncidentsTab.TabIndex = 2;
            this.SearchIncidentsTab.Text = "Search Incidents";
            this.SearchIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // searchIncidentsUserControl1
            // 
            this.searchIncidentsUserControl1.Location = new System.Drawing.Point(18, 0);
            this.searchIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(0);
            this.searchIncidentsUserControl1.MaximumSize = new System.Drawing.Size(889, 800);
            this.searchIncidentsUserControl1.Name = "searchIncidentsUserControl1";
            this.searchIncidentsUserControl1.Size = new System.Drawing.Size(889, 605);
            this.searchIncidentsUserControl1.TabIndex = 0;
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.Location = new System.Drawing.Point(687, 55);
            this.logoutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(72, 25);
            this.logoutLabel.TabIndex = 1;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            // 
            // currentUsernameLabel
            // 
            this.currentUsernameLabel.AutoSize = true;
            this.currentUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUsernameLabel.Location = new System.Drawing.Point(687, 29);
            this.currentUsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentUsernameLabel.Name = "currentUsernameLabel";
            this.currentUsernameLabel.Size = new System.Drawing.Size(0, 25);
            this.currentUsernameLabel.TabIndex = 5;
            // 
            // DisplayOpenIncidentsTab
            // 
            this.DisplayOpenIncidentsTab.Location = new System.Drawing.Point(4, 41);
            this.DisplayOpenIncidentsTab.Name = "DisplayOpenIncidentsTab";
            this.DisplayOpenIncidentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.DisplayOpenIncidentsTab.Size = new System.Drawing.Size(924, 604);
            this.DisplayOpenIncidentsTab.TabIndex = 3;
            this.DisplayOpenIncidentsTab.Text = "DisplayOpenIncidents";
            this.DisplayOpenIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 748);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.currentUsernameLabel);
            this.Controls.Add(this.logoutLabel);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.mainTabControl.ResumeLayout(false);
            this.AddIncidentTab.ResumeLayout(false);
            this.LoadIncidentsTab.ResumeLayout(false);
            this.SearchIncidentsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage AddIncidentTab;
        private System.Windows.Forms.TabPage LoadIncidentsTab;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.Label currentUsernameLabel;
        private System.Windows.Forms.TabPage SearchIncidentsTab;
        private UserControls.SearchIncidentsUserControl searchIncidentsUserControl1;
        private UserControls.LoadIncidentUserControl loadIncidentUserControl1;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
        private System.Windows.Forms.TabPage DisplayOpenIncidentsTab;
    }
}