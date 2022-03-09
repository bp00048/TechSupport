using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// This class updates or closes a currently open incident.
    /// </summary>

    public partial class UpdateUserControl : UserControl
    {
        IncidentController inController = new IncidentController();

        /// <summary>
        /// Incident is for the incident currently being manipulated by the form.
        /// </summary>
        Incident Incident;

        /// <summary>
        /// Initializes the component and sets customerName, productCode, title, dateOpened, and description text boxes as read only
        /// Sets the technician combo box as unassigned.
        /// Disables the update and close button.
        /// </summary>
        public UpdateUserControl()
        {
            InitializeComponent();
            this.customerNameTextBox.ReadOnly = true;
            this.productCodeTextBox.ReadOnly = true;
            this.titleTextBox.ReadOnly = true;
            this.dateOpenedTextBox.ReadOnly = true;
            this.descriptionTextBox.ReadOnly = true;
            this.updateButton.Enabled = false;
            this.closeButton.Enabled = false;


        }

        private void GetIncidentButton_Click(object sender, EventArgs e)
        {
            if (this.incidentIDTextBox.Text == null || this.incidentIDTextBox.Text == "")
            {
                MessageBox.Show("The incidentID cannot be empty.");

            }

            else
            {

                try
                {
                    int incidentID = int.Parse(this.incidentIDTextBox.Text);
                    Incident searchIncident = new Incident();
                    searchIncident.IncidentID = incidentID;
                    if (inController.CheckIncidentStatus(searchIncident))
                    {
                        Incident = inController.GetIncident(searchIncident);
                        this.FillForm(Incident);
                        this.enableButtons();
                    }
                    else
                    {
                        MessageBox.Show("There are no open incidents assigned to that ID.");
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("ID must be a number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }


        private void AddTechNameToComboBox()
        {

            try
            {

                List<Incident> incidentList = this.inController.GetIncidents();
                if (incidentList.Count > 0)
                {
                    var technicianSource = new BindingSource(this.inController.GetTechnicians(), null);
                    technicianSource.Add(new KeyValuePair<int, string>(0, "--Unassigned--"));

                    this.technicianComboBox.DataSource = technicianSource;
                    this.technicianComboBox.DisplayMember = "Value";
                    this.technicianComboBox.ValueMember = "Key";
                    if (Incident.TechnicianName.ToString() == "")
                    {
                        this.technicianComboBox.SelectedIndex = this.technicianComboBox.Items.Count - 1;
                    }
                    else
                    {
                        this.technicianComboBox.SelectedIndex = this.technicianComboBox.FindString(Incident.TechnicianName.ToString());

                    }

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

        private void enableButtons()
        {
            this.updateButton.Enabled = true;
            this.closeButton.Enabled = true;
        }
        private void FillForm(Incident incident)
        {

            this.customerNameTextBox.Text = incident.CustomerName;
            this.productCodeTextBox.Text = incident.ProductCode;
            this.dateOpenedTextBox.Text = incident.DateOpened.ToShortDateString();
            this.titleTextBox.Text = incident.Title;
            this.descriptionTextBox.Text = incident.Description;
            this.AddTechNameToComboBox();

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            var techID = ((KeyValuePair<int, string>)this.technicianComboBox.SelectedItem).Key;
            string textToAdd = Incident.Description + "\r\n< " + DateTime.Now.ToShortDateString() + " > " + this.textToAddTextBox.Text;
            if (this.textToAddTextBox.Text == "" && (techID == 0 || techID == Incident.TechID))
            {

                MessageBox.Show("You must either change the technician or add text.");
}
            else if (this.Incident.Description.Length > 200 && (techID == 0 || techID == Incident.TechID))
            {
                MessageBox.Show("You cannot add any more to the description. You may only change the technician.");
            }
             else if (textToAddTextBox.Text.Length > 200)
                {

                    if (CheckTextLength() == DialogResult.OK)
                    {

                        this.UpdateIncident(Incident, techID, textToAdd.Substring(0, 200));
                    }

             }
              else
                {

                    this.UpdateIncident(Incident, techID, textToAdd);
                }
            
        }

      
        private bool validateForm()
        {
            var techID = ((KeyValuePair<int, string>)this.technicianComboBox.SelectedItem).Key;
            if (techID == 0)
            {
                MessageBox.Show("Must select a technician.");
                return false;
            }
            else if (techID == Incident.TechID)
            {
                if (this.textToAddTextBox.Text == "")
                {

                    MessageBox.Show("Must add text or change technician to update incident.");
                    return false;
                }
                else if (this.descriptionTextBox.Text.Length >= 200 && this.textToAddTextBox.Text.Length != 0)
                {
                    MessageBox.Show("You cannot add any more added text. Please remove added text and try again.");
                    return false;
                }
            }
            return true;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            
            string textToAdd = Incident.Description + "\r\n< " + DateTime.Now.ToShortDateString() + " > Closed " + this.textToAddTextBox.Text;
            var techID = ((KeyValuePair<int, string>)this.technicianComboBox.SelectedItem).Key;

            if (techID == 0)
            {
                MessageBox.Show("Must have assigned Technician!");
         
            } else if ((this.descriptionTextBox.Text.Length >= 200 && this.textToAddTextBox.Text.Length != 0) || (this.textToAddTextBox.Text.Length > 200))
            {

                 if (CheckTextLength() == DialogResult.OK)
                {
                    this.CloseIncident(Incident, techID, textToAdd.Substring(0, 200));
                }
             
            } else
            {
                this.CloseIncident(Incident, techID, textToAdd);
            }

        }
        private void CloseIncident(Incident incident, int techID, string description)
        {
            try
            {
              
                    if (ConfirmationClose() == DialogResult.OK)
                    {
                        Incident.DateClosed = DateTime.Now.ToString();
                        incident.TechID = techID;
                        incident.Description = description;
                        inController.CloseIncident(incident);
                        this.textToAddTextBox.Clear();
                        this.descriptionTextBox.Text = incident.Description;
                        MessageBox.Show("Incident has been closed.");
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateIncident(Incident incident, int techID, string description)
        {
            try
            {
               
                    incident.TechID = techID;
                    incident.Description = description;
                    inController.UpdateIncident(incident);
                    this.textToAddTextBox.Clear();
                    this.descriptionTextBox.Text = incident.Description;
                    MessageBox.Show("Incident has been updated.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private DialogResult CheckTextLength()
        {
            DialogResult truncateTextDialog = MessageBox.Show("Added description will be shortened to 200 characters.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            return truncateTextDialog;
        }

        private DialogResult ConfirmationClose()
        {
            DialogResult confirmationDialog = MessageBox.Show("Incident cannot be updated after it is closed. Are you sure you wish to close this incident?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            return confirmationDialog;
        
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.incidentIDTextBox.Clear();
            this.clearForm();
        }

        private void incidentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.clearForm();
        }
        
        private void clearForm()
        {
            
            this.textToAddTextBox.Clear();
            this.descriptionTextBox.Clear();
            this.technicianComboBox.SelectedIndex = -1;
            this.dateOpenedTextBox.Clear();
            this.customerNameTextBox.Clear();
            this.titleTextBox.Clear();
            this.productCodeTextBox.Clear();
        }
    }
}
