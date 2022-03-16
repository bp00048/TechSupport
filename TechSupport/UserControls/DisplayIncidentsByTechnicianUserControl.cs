using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Class that allows the user to select a technician from the dropdown and display all incidents designated to that technician.
    /// </summary>
    public partial class DisplayIncidentsByTechnicianUserControl : UserControl
    {

        private TechnicianController techController;
        IncidentController inController;

        List<Incident> incidentList;
        private List<Technician> technicianList;
        /// <summary>
        /// Constructor that initializes the TechnicianController and IncidentController. 
        /// Also changes the emailTextBox and phoneTextBox to be disabled/read only.
        /// </summary>
        public DisplayIncidentsByTechnicianUserControl()
        {
            InitializeComponent();
            techController = new TechnicianController();
            inController = new IncidentController();
            this.emailTextBox.ReadOnly = true;
            this.phoneTextBox.ReadOnly = true;

        }

        /// <summary>
        /// Refreshes the techniciansList data source.
        /// </summary>
        public void LoadIncidents()
        {

            technicianList = techController.GetAllTechnicians();
            nameComboBox.DataSource = technicianList;
        }
       
        private void DisplayIncidentsByTechnicianUserControl_Load(object sender, EventArgs e)
        {

            this.LoadIncidents();

        }

        private void NameComboBox_SelectIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedIndex < 0)
            {
                return;
            }
            try
            {
                Technician technician = technicianList[nameComboBox.SelectedIndex];
                technicianBindingSource.Clear();
                technicianBindingSource.Add(technician);

                incidentList = inController.GetAllIncidentsByTechnician(technician.TechID);
                incidentByTechnicianDataGridView.DataSource = incidentList;
            }
            catch (FormatException)
            {
                MessageBox.Show("Technician ID is invalid.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

