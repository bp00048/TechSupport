using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{

    
    public partial class UpdateUserControl : UserControl
    {
        IncidentController inController = new IncidentController();
        public UpdateUserControl()
        {
            InitializeComponent();
        }

        private void GetIncidentButton_Click(object sender, EventArgs e)
        {
            int incidentID;
            Incident incident;
            incidentID = int.Parse(this.incidentIDTextBox.Text);
            incident = inController.getIncident(incidentID);


        }

        private void FillForm(Incident incident)
        {
            this.customerNameTextBox.Text = incident.CustomerName;
            this.productCodeTextBox.Text = incident.ProductCode;
            this.titleLabel.Text = incident.Title;
            this.dateOpenedTextBox.Text = incident.DateOpened.ToString();
            this.descriptionTextBox.Text = incident.Description;

        }
    }
}
