
namespace TechSupport.View
{
    partial class SearchIncidentDialog
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
            this.searchResultGridView = new System.Windows.Forms.DataGridView();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchResultGridView
            // 
            this.searchResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultGridView.Location = new System.Drawing.Point(195, 159);
            this.searchResultGridView.Name = "searchResultGridView";
            this.searchResultGridView.Size = new System.Drawing.Size(406, 260);
            this.searchResultGridView.TabIndex = 0;
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.Location = new System.Drawing.Point(255, 70);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(114, 22);
            this.customerIDLabel.TabIndex = 1;
            this.customerIDLabel.Text = "Customer ID:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(398, 72);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(150, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(341, 118);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(115, 35);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchIncidentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.searchResultGridView);
            this.Name = "SearchIncidentDialog";
            this.Text = "SearchIncidentDialog";
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchResultGridView;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}