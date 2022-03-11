using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class DisplayIncidentsByTechnicianUserControl : UserControl
    {

        private TechnicianController techController;
        IncidentController inController;

        List<Incident> incidentList;
        private List<Technician> technicianList;
        public DisplayIncidentsByTechnicianUserControl()
        {
            InitializeComponent();
            techController = new TechnicianController();
            inController = new IncidentController();
            this.emailTextBox.ReadOnly = true;
            this.phoneTextBox.ReadOnly = true;

        }

        private void DisplayIncidentsByTechnicianUserControl_Load(object sender, EventArgs e)
        {
            
            technicianList = techController.GetAllTechnicians();
            nameComboBox.DataSource = technicianList;


        }

        private void NameComboBox_SelectIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedIndex < 0)
            {

                return;

            }

            Technician technician = technicianList[nameComboBox.SelectedIndex];
            technicianBindingSource.Clear();
            technicianBindingSource.Add(technician);

            incidentList = inController.GetAllIncidentsByTechnician(technician.TechID);
            incidentByTechnicianDataGridView.DataSource = incidentList;
        }
    }
    }

