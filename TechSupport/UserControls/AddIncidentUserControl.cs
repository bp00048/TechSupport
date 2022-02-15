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
        private List<Incident> incidentList;


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
        /// Triggered by the user clicking the add button. It attempts to submit the inputted text as the title, description and selected customer and product. If 
        /// successful, "incident is added!" alerts the user and the incident is added. If not, a message box appears indicating the issue and the incident
        /// is not added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIncidentButton_Click(object sender, System.EventArgs e)

        { 
            if (this.titleTextBox.Text == null || this.titleTextBox.Text == "")
            {
                MessageBox.Show("Must have a title.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.descriptionTextBox.Text == null || this.descriptionTextBox.Text == "")
            {
                MessageBox.Show("Must have a description", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                this.AddOpenIncident();
            }
        }




            private void AddOpenIncident()
            {
                try
                {
                   var customerID = ((KeyValuePair<int, string>)this.customerComboBox.SelectedItem).Key;
                   var productCode = ((KeyValuePair<string, string>)this.productComboBox.SelectedItem).Key;
                   var title = this.titleTextBox.Text;
                   var description = this.descriptionTextBox.Text;
                    
                   Incident newAddedIncident = new Incident();

                    newAddedIncident.CustomerID = int.Parse(customerID.ToString());
                    newAddedIncident.Title = title;
                    newAddedIncident.Description = description;
                    newAddedIncident.ProductCode = productCode.ToString();


                    inController.AddOpenIncident(newAddedIncident);
                this.Clear();
                this.messageLabel.Text = "Open Incident successfully added!";
                    

              

                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        private void AddIncidentUserControl_Load(object sender, EventArgs e)
        {
          
            try
            {
                incidentList = this.inController.GetOpenIncidents();

                if (incidentList.Count > 0)
                {
    
                    this.customerComboBox.DataSource = new BindingSource(this.inController.GetCustomers(), null);
                    this.customerComboBox.DisplayMember = "Value";
                    this.customerComboBox.ValueMember = "Key";
                    this.productComboBox.DataSource = new BindingSource(this.inController.GetProducts(), null);
                    this.productComboBox.DisplayMember = "Value";
                    this.productComboBox.ValueMember = "Key";
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
    
    private void Clear()
        {
            this.titleTextBox.Clear();
            this.descriptionTextBox.Clear();
            customerComboBox.SelectedIndex = 0;
            productComboBox.SelectedIndex = 0;
            this.messageLabel.Text = "";

        }

    private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Clear();
        
        }

        private void TextBoxChanged(object sender, EventArgs e)
        {
            this.messageLabel.Text = "";
        }

   
    }
}

    