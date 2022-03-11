
namespace TechSupport.UserControls
{
    partial class DisplayOpenIncidentsUserControl
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
            this.ProductCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOpened = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Technician = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenIncidentsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ProductCode
            // 
            this.ProductCode.Text = "Product Code";
            this.ProductCode.Width = 95;
            // 
            // DateOpened
            // 
            this.DateOpened.Text = "Date Opened";
            this.DateOpened.Width = 95;
            // 
            // Customer
            // 
            this.Customer.Text = "Customer";
            this.Customer.Width = 86;
            // 
            // Technician
            // 
            this.Technician.Text = "Technician";
            this.Technician.Width = 66;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 212;
            // 
            // OpenIncidentsListView
            // 
            this.OpenIncidentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductCode,
            this.DateOpened,
            this.Customer,
            this.Technician,
            this.Title});
            this.OpenIncidentsListView.HideSelection = false;
            this.OpenIncidentsListView.Location = new System.Drawing.Point(12, 22);
            this.OpenIncidentsListView.Name = "OpenIncidentsListView";
            this.OpenIncidentsListView.Size = new System.Drawing.Size(497, 342);
            this.OpenIncidentsListView.TabIndex = 6;
            this.OpenIncidentsListView.UseCompatibleStateImageBehavior = false;
            this.OpenIncidentsListView.View = System.Windows.Forms.View.Details;
            // 
            // DisplayOpenIncidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OpenIncidentsListView);
            this.Name = "DisplayOpenIncidentsUserControl";
            this.Size = new System.Drawing.Size(529, 408);
            this.Load += new System.EventHandler(this.DisplayOpenIncidentsUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader ProductCode;
        private System.Windows.Forms.ColumnHeader DateOpened;
        private System.Windows.Forms.ColumnHeader Customer;
        private System.Windows.Forms.ColumnHeader Technician;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ListView OpenIncidentsListView;
    }
}
