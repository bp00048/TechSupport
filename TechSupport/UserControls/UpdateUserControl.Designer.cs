
namespace TechSupport.UserControls
{
    partial class UpdateUserControl
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
            this.incidentIDLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.technicianLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateOpenedLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.textToAddLabel = new System.Windows.Forms.Label();
            this.incidentIDTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dateOpenedTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.textToAddTextBox = new System.Windows.Forms.TextBox();
            this.technicianComboBox = new System.Windows.Forms.ComboBox();
            this.getIncidentButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // incidentIDLabel
            // 
            this.incidentIDLabel.AutoSize = true;
            this.incidentIDLabel.Location = new System.Drawing.Point(17, 14);
            this.incidentIDLabel.Name = "incidentIDLabel";
            this.incidentIDLabel.Size = new System.Drawing.Size(91, 20);
            this.incidentIDLabel.TabIndex = 0;
            this.incidentIDLabel.Text = "Incident ID:";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(17, 46);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 20);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Customer:";
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(17, 81);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(68, 20);
            this.productCodeLabel.TabIndex = 2;
            this.productCodeLabel.Text = "Product:";
            // 
            // technicianLabel
            // 
            this.technicianLabel.AutoSize = true;
            this.technicianLabel.Location = new System.Drawing.Point(17, 115);
            this.technicianLabel.Name = "technicianLabel";
            this.technicianLabel.Size = new System.Drawing.Size(89, 20);
            this.technicianLabel.TabIndex = 3;
            this.technicianLabel.Text = "Technician:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(17, 147);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 20);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title:";
            // 
            // dateOpenedLabel
            // 
            this.dateOpenedLabel.AutoSize = true;
            this.dateOpenedLabel.Location = new System.Drawing.Point(17, 179);
            this.dateOpenedLabel.Name = "dateOpenedLabel";
            this.dateOpenedLabel.Size = new System.Drawing.Size(109, 20);
            this.dateOpenedLabel.TabIndex = 5;
            this.dateOpenedLabel.Text = "Date Opened:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(17, 205);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(93, 20);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Description:";
            // 
            // textToAddLabel
            // 
            this.textToAddLabel.AutoSize = true;
            this.textToAddLabel.Location = new System.Drawing.Point(17, 262);
            this.textToAddLabel.Name = "textToAddLabel";
            this.textToAddLabel.Size = new System.Drawing.Size(98, 20);
            this.textToAddLabel.TabIndex = 7;
            this.textToAddLabel.Text = "Text To Add:";
            // 
            // incidentIDTextBox
            // 
            this.incidentIDTextBox.Location = new System.Drawing.Point(160, 11);
            this.incidentIDTextBox.Name = "incidentIDTextBox";
            this.incidentIDTextBox.Size = new System.Drawing.Size(122, 26);
            this.incidentIDTextBox.TabIndex = 8;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(160, 43);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(372, 26);
            this.customerNameTextBox.TabIndex = 9;
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Location = new System.Drawing.Point(160, 75);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(372, 26);
            this.productCodeTextBox.TabIndex = 10;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(160, 141);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(372, 26);
            this.titleTextBox.TabIndex = 11;
            // 
            // dateOpenedTextBox
            // 
            this.dateOpenedTextBox.Location = new System.Drawing.Point(160, 173);
            this.dateOpenedTextBox.Name = "dateOpenedTextBox";
            this.dateOpenedTextBox.Size = new System.Drawing.Size(122, 26);
            this.dateOpenedTextBox.TabIndex = 12;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(160, 205);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(340, 48);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // textToAddTextBox
            // 
            this.textToAddTextBox.Location = new System.Drawing.Point(160, 259);
            this.textToAddTextBox.Multiline = true;
            this.textToAddTextBox.Name = "textToAddTextBox";
            this.textToAddTextBox.Size = new System.Drawing.Size(340, 54);
            this.textToAddTextBox.TabIndex = 14;
            // 
            // technicianComboBox
            // 
            this.technicianComboBox.FormattingEnabled = true;
            this.technicianComboBox.Location = new System.Drawing.Point(160, 107);
            this.technicianComboBox.Name = "technicianComboBox";
            this.technicianComboBox.Size = new System.Drawing.Size(372, 28);
            this.technicianComboBox.TabIndex = 15;
            // 
            // getIncidentButton
            // 
            this.getIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getIncidentButton.Location = new System.Drawing.Point(300, 9);
            this.getIncidentButton.Name = "getIncidentButton";
            this.getIncidentButton.Size = new System.Drawing.Size(81, 27);
            this.getIncidentButton.TabIndex = 16;
            this.getIncidentButton.Text = "Get";
            this.getIncidentButton.UseVisualStyleBackColor = true;
            this.getIncidentButton.Click += new System.EventHandler(this.GetIncidentButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(170, 315);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(72, 28);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(280, 315);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(72, 28);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(402, 315);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(72, 28);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // UpdateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.getIncidentButton);
            this.Controls.Add(this.technicianComboBox);
            this.Controls.Add(this.textToAddTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.dateOpenedTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.incidentIDTextBox);
            this.Controls.Add(this.textToAddLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.dateOpenedLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.technicianLabel);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.incidentIDLabel);
            this.Name = "UpdateUserControl";
            this.Size = new System.Drawing.Size(547, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incidentIDLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Label technicianLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dateOpenedLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label textToAddLabel;
        private System.Windows.Forms.TextBox incidentIDTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox dateOpenedTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox textToAddTextBox;
        private System.Windows.Forms.ComboBox technicianComboBox;
        private System.Windows.Forms.Button getIncidentButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
    }
}
