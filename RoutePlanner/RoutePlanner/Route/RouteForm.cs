using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RoutePlanner.Main.Dijkstra;
using RoutePlanner.Main;
using RoutePlanner.Data;
using RoutePlanner.Network;

namespace RoutePlanner.Route
{
    public partial class RouteForm : Form
    {
        private RouteController controller;

        public RouteForm(RouteController control)
        {
            InitializeComponent();
            controller = control;
        }

        private void RouteForm_Load(object sender, EventArgs e)
        {
            ISet<string> stations = controller.getNodes();

            foreach (string station in stations)
            {
                cmb_box_start.Items.Add(station);
                cmb_box_destination.Items.Add(station);
            }
        }

        private void btn_findRoutes_Click(object sender, EventArgs e)
        {
            if (cmb_box_start.SelectedIndex < 0 || cmb_box_destination.SelectedIndex < 0)
            {
                MessageBox.Show("Stations cannot be blank!, please choose two different stations.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb_box_start.SelectedItem.ToString() == cmb_box_destination.SelectedItem.ToString())
            {
                MessageBox.Show("Stations cannot be the same!, please choose two different stations.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                IList<RouteOutput> journey = controller.startDijkstra(cmb_box_start.SelectedItem.ToString(), cmb_box_destination.SelectedItem.ToString());
                txt_box_journeys.Clear();
                txt_box_journeys.AppendText(journey[0].journeyStart + journey[0].journeyEnd);

                for (int i = 0; i < journey.Count; i++)
                {
                    txt_box_journeys.AppendText("\r\n\r\nOption: " + (i + 1) + "\r\n" +
                        journey[i].journeyInfo + "\r\nLine Changes: " + journey[i].numOfLineChanges + "\r\nTotal Stops: " + journey[i].numOfStops);
                }
            }
        }
    }
}
