
namespace TechSupport.View
{
    partial class MainForm
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
            this.currentUsernameLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.searchIncidentButton = new System.Windows.Forms.Button();
            this.incidentList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.incidentList)).BeginInit();
            this.SuspendLayout();
            // 
            // currentUsernameLabel
            // 
            this.currentUsernameLabel.AutoSize = true;
            this.currentUsernameLabel.Location = new System.Drawing.Point(659, 9);
            this.currentUsernameLabel.Name = "currentUsernameLabel";
            this.currentUsernameLabel.Size = new System.Drawing.Size(0, 13);
            this.currentUsernameLabel.TabIndex = 0;
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(659, 43);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(40, 13);
            this.logoutLabel.TabIndex = 1;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabel_LinkClicked);
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.AutoSize = true;
            this.addIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentButton.Location = new System.Drawing.Point(203, 104);
            this.addIncidentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(119, 32);
            this.addIncidentButton.TabIndex = 1;
            this.addIncidentButton.Text = "Add Incident";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            // 
            // searchIncidentButton
            // 
            this.searchIncidentButton.AutoSize = true;
            this.searchIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIncidentButton.Location = new System.Drawing.Point(367, 104);
            this.searchIncidentButton.Name = "searchIncidentButton";
            this.searchIncidentButton.Size = new System.Drawing.Size(144, 32);
            this.searchIncidentButton.TabIndex = 2;
            this.searchIncidentButton.Text = "Search Incident";
            this.searchIncidentButton.UseVisualStyleBackColor = true;
            // 
            // incidentList
            // 
            this.incidentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentList.Location = new System.Drawing.Point(98, 157);
            this.incidentList.Name = "incidentList";
            this.incidentList.Size = new System.Drawing.Size(497, 267);
            this.incidentList.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incidentList);
            this.Controls.Add(this.searchIncidentButton);
            this.Controls.Add(this.addIncidentButton);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.currentUsernameLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainClosing);
            ((System.ComponentModel.ISupportInitialize)(this.incidentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentUsernameLabel;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button searchIncidentButton;
        private System.Windows.Forms.DataGridView incidentList;
    }
}