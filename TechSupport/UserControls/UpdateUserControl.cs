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
            if (this.incidentIDTextBox.Text == null || this.incidentIDTextBox.Text == "")
            {
                MessageBox.Show("The incidentID cannot be empty.");
             
            } else { 

            try
            {
               int incidentID = int.Parse(this.incidentIDTextBox.Text);
                if (inController.checkIncident(incidentID))
                {
                    Incident incident = inController.getIncident(incidentID);
                    this.FillForm(incident);
                }
                else
                {
                    MessageBox.Show("There are no incidents assigned to that ID.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input \n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }


        }

        private void FillForm(Incident incident)
        {
            
            this.customerNameTextBox.Text = incident.CustomerName;
            this.productCodeTextBox.Text = incident.ProductCode;
            this.dateOpenedTextBox.Text = incident.DateOpened.ToString();
            this.titleTextBox.Text = incident.Title;
            
            this.descriptionTextBox.Text = incident.Description;

        }
    }
}
