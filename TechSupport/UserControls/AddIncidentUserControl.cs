using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// This class is a user control that adds incidents to the in-memory list.
    /// </summary>
    public partial class AddIncidentUserControl : UserControl
    {

        private IncidentController inController;
       
        /// <summary>
        /// Constructor that intializes the component and a new Incident controller object.
        /// </summary>
        public AddIncidentUserControl()
        {
            InitializeComponent();
            inController = new IncidentController();
            this.Load += new System.EventHandler(AddIncidentUserControl_Load);

        }
        /// <summary>
        /// Triggered by the user clicking the add button. It attempts to submit the inputted text as the title, description and customerID. If 
        /// successful, "incident is added!" alerts the user and the incident is added. If not, a message box appears indicating the issue and the incident
        /// is not added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIncidentButton_Click(object sender, System.EventArgs e)
        {
         
            try
            {
               // var title = this.titleTextBox.Text;
               // var description = this.descriptionTextBox.Text;
               

               // this.incidentController.Add(new Model.Incident(title, description, customerID));
               // this.messageLabel.Text = "Incident is added!";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Customer ID must be a number \n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           
          
        }

        private void AddIncidentUserControl_Load(object sender, EventArgs e)
        {
            List<Incident> incidentList;
            try
            {
                incidentList = this.inController.GetOpenIncidents();

                if (incidentList.Count > 0)
                {
                    customerComboBox.Items.Add("--Please Select--");
                    productComboBox.Items.Add("--Please Select--");
                    Incident incident;
                    for (int i = 0; i < incidentList.Count; i++)
                    {

                        incident = incidentList[i];

                        customerComboBox.Items.Add(incident.CustomerName);
                        productComboBox.Items.Add(incident.ProductName);
                      

                    }
                    customerComboBox.SelectedIndex = 0;
                    productComboBox.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No open incidents.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    


    private void ClearButton_Click(object sender, EventArgs e)
        {
            this.titleTextBox.Clear();
            this.descriptionTextBox.Clear();
       
            this.messageLabel.Text = "";
        }

        private void TextBoxChanged(object sender, EventArgs e)
        {
            this.messageLabel.Text = "";
        }

   
    }
}

    