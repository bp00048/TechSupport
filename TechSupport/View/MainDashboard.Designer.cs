
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
            this.addIncidentTab = new System.Windows.Forms.TabPage();
            this.loadIncidentsTab = new System.Windows.Forms.TabPage();
            this.searchIncidentsTab = new System.Windows.Forms.TabPage();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.currentUsernameLabel = new System.Windows.Forms.Label();
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.loadIncidentUserControl1 = new TechSupport.UserControls.LoadIncidentUserControl();
            this.searchIncidentsUserControl1 = new TechSupport.UserControls.SearchIncidentsUserControl();
            this.mainTabControl.SuspendLayout();
            this.addIncidentTab.SuspendLayout();
            this.loadIncidentsTab.SuspendLayout();
            this.searchIncidentsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.addIncidentTab);
            this.mainTabControl.Controls.Add(this.loadIncidentsTab);
            this.mainTabControl.Controls.Add(this.searchIncidentsTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 99);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(832, 649);
            this.mainTabControl.TabIndex = 0;
            // 
            // addIncidentTab
            // 
            this.addIncidentTab.Controls.Add(this.addIncidentUserControl1);
            this.addIncidentTab.Location = new System.Drawing.Point(4, 41);
            this.addIncidentTab.Name = "addIncidentTab";
            this.addIncidentTab.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTab.Size = new System.Drawing.Size(824, 604);
            this.addIncidentTab.TabIndex = 0;
            this.addIncidentTab.Text = "Add Incident";
            this.addIncidentTab.UseVisualStyleBackColor = true;
            // 
            // loadIncidentsTab
            // 
            this.loadIncidentsTab.Controls.Add(this.loadIncidentUserControl1);
            this.loadIncidentsTab.Location = new System.Drawing.Point(4, 41);
            this.loadIncidentsTab.Name = "loadIncidentsTab";
            this.loadIncidentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.loadIncidentsTab.Size = new System.Drawing.Size(824, 604);
            this.loadIncidentsTab.TabIndex = 1;
            this.loadIncidentsTab.Text = "Load Incidents";
            this.loadIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // searchIncidentsTab
            // 
            this.searchIncidentsTab.Controls.Add(this.searchIncidentsUserControl1);
            this.searchIncidentsTab.Location = new System.Drawing.Point(4, 41);
            this.searchIncidentsTab.Name = "searchIncidentsTab";
            this.searchIncidentsTab.Size = new System.Drawing.Size(824, 604);
            this.searchIncidentsTab.TabIndex = 2;
            this.searchIncidentsTab.Text = "Search Incidents";
            this.searchIncidentsTab.UseVisualStyleBackColor = true;
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
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addIncidentUserControl1.Location = new System.Drawing.Point(26, 37);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.addIncidentUserControl1.MaximumSize = new System.Drawing.Size(1244, 800);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(763, 499);
            this.addIncidentUserControl1.TabIndex = 0;

            // 
            // loadIncidentUserControl1
            // 
            this.loadIncidentUserControl1.Location = new System.Drawing.Point(12, 50);
            this.loadIncidentUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.loadIncidentUserControl1.Name = "loadIncidentUserControl1";
            this.loadIncidentUserControl1.Size = new System.Drawing.Size(802, 529);
            this.loadIncidentUserControl1.TabIndex = 0;
            // 
            // searchIncidentsUserControl1
            // 
            this.searchIncidentsUserControl1.Location = new System.Drawing.Point(5, 0);
            this.searchIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(0);
            this.searchIncidentsUserControl1.MaximumSize = new System.Drawing.Size(889, 800);
            this.searchIncidentsUserControl1.Name = "searchIncidentsUserControl1";
            this.searchIncidentsUserControl1.Size = new System.Drawing.Size(802, 605);
            this.searchIncidentsUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 748);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.currentUsernameLabel);
            this.Controls.Add(this.logoutLabel);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.mainTabControl.ResumeLayout(false);
            this.addIncidentTab.ResumeLayout(false);
            this.loadIncidentsTab.ResumeLayout(false);
            this.searchIncidentsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage addIncidentTab;
        private System.Windows.Forms.TabPage loadIncidentsTab;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.Label currentUsernameLabel;
        private System.Windows.Forms.TabPage searchIncidentsTab;
        private UserControls.SearchIncidentsUserControl searchIncidentsUserControl1;
        private UserControls.LoadIncidentUserControl loadIncidentUserControl1;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
    }
}