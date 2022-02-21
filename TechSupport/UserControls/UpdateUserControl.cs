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
        Incident Incident;
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
            this.technicianComboBox.Items.Insert(0, "--Unassigned--");
            this.technicianComboBox.SelectedIndex = 0;
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
                    if (inController.CheckIncident(incidentID))
                    {
                        Incident = inController.GetIncident(incidentID);
                        this.FillForm(Incident);
                        this.enableButtons();
                    }
                    else
                    {
                        MessageBox.Show("There are no open incidents assigned to that ID.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is wrong with the input \n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void AddTechNameToComboBox()
        {

            try
            {

                List<Incident> incidentList = this.inController.GetOpenIncidents();
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
            if (techID == 0)
            {
                MessageBox.Show("Must have assigned Technician!");
            }
            else if (this.textToAddTextBox.Text == "")
            {
                MessageBox.Show("Must add text to update Incident.");
            }
            else if (this.textToAddTextBox.Text.Length == 200)
            {
                MessageBox.Show("Description cannot be any longer. Please leave additional text blank.");
            }
            else
            {
                if (textToAdd.Length > 200)
                {
                    if (CheckTextLength() == DialogResult.OK)
                    {
                        Incident.TechID = techID;
                        Incident.Description = textToAdd.Substring(0, 200);
                        this.UpdateIncident(Incident);

                    }
                }
                else
                {
                    Incident.TechID = techID;
                    Incident.Description = textToAdd;
                    this.UpdateIncident(Incident);
                }

            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Incident.DateClosed = DateTime.Now.ToString();
            string textToAdd = Incident.Description + "\r\n< " + DateTime.Now.ToShortDateString() + " > Closed " + this.textToAddTextBox.Text;
            var techID = ((KeyValuePair<int, string>)this.technicianComboBox.SelectedItem).Key;
            if (techID == 0)
            {
                MessageBox.Show("Must have assigned Technician!");
            }
            else if (this.descriptionTextBox.Text.Length == 200 && this.textToAddTextBox.Text.Length != 0)
            {
                MessageBox.Show("Description cannot be any longer. Please leave additional text blank.");
            }
            else
            {

                if (textToAdd.Length > 200 && CheckTextLength() == DialogResult.OK)
                {
                    Incident.TechID = techID;
                    Incident.Description = textToAdd.Substring(0, 200);
                    this.CloseIncident(Incident);

                } else
                {
                    Incident.TechID = techID;
                    Incident.Description = textToAdd;
                    this.CloseIncident(Incident);
                }


            }
        }

        private void CloseIncident(Incident incident)
        {
            if (inController.CheckChanges(incident))
            {
                MessageBox.Show("Incident has been updated already. Please reload incident.");
            }
            else if (ConfirmationClose() == DialogResult.OK)
            {
                inController.CloseIncident(Incident);
                this.textToAddTextBox.Clear();
                this.descriptionTextBox.Text = Incident.Description;
                MessageBox.Show("Incident has been closed.");
            }
        }

        private void UpdateIncident(Incident incident)
        {
            if (inController.CheckChanges(incident))
            {
                MessageBox.Show("Incident has been updated already. Please reload incident.");
            }
            inController.UpdateIncident(Incident);
            this.textToAddTextBox.Clear();
            this.descriptionTextBox.Text = Incident.Description;
            MessageBox.Show("Incident has been updated.");
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
    }
}
