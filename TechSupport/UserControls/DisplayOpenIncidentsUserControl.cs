using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class DisplayOpenIncidentsUserControl : UserControl
    {
        private IncidentController inController;

        public DisplayOpenIncidentsUserControl()
        {
            InitializeComponent();
            inController = new IncidentController();
        }

        private void DisplayOpenIncidents_Load(object sender, EventArgs e)
        {
            List<Incident> incidentList;
            try
            {
                incidentList = this.inController.GetOpenIncidents();

                if (incidentList.Count > 0)
                {
                    Incident incident;
                    for (int i = 0; i < incidentList.Count; i++)
                    {

                        incident = incidentList[i];
                        OpenIncidentsListView.Items.Add(incident.ProductCode);

                        OpenIncidentsListView.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                        OpenIncidentsListView.Items[i].SubItems.Add(incident.CustomerName);
                        OpenIncidentsListView.Items[i].SubItems.Add(incident.TechnicianName);
                        OpenIncidentsListView.Items[i].SubItems.Add(incident.Title);

                    }
                }
                else
                {
                    MessageBox.Show("All incidents cleared.", "No open incidents.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());

            }
            
        }
    }
}

