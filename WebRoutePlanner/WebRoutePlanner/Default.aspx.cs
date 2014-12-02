using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoutePlanner.Data;
using RoutePlanner.Main.Dijkstra;
using RoutePlanner.Network;
using RoutePlanner.Route;

namespace WebRoutePlanner
{
    public partial class _Default : System.Web.UI.Page
    {
        private RouteController controller = new RouteController();

        protected void Page_Load(object sender, EventArgs e)
        {

            ISet<string> stations = controller.getNodes();

            foreach (string station in stations)
            {
                drp_dwn_start.Items.Add(station);
                drp_dwn_destination.Items.Add(station);
            }
        }

        protected void routes_btn_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                IList<RouteOutput> journey = controller.startDijkstra(drp_dwn_start.SelectedItem.ToString(), drp_dwn_destination.SelectedItem.ToString());

                txt_box_journey.Text = "";
                txt_box_journey.Text += (journey[0].journeyStart + journey[0].journeyEnd);

                for (int i = 0; i < journey.Count; i++)
                {
                    txt_box_journey.Text += ("\r\n\r\nOption: " + (i + 1) + "\r\n" + journey[i].journeyInfo + "\r\nLine Changes: " +
                                            journey[i].numOfLineChanges + "\r\nTotal Stops: " + journey[i].numOfStops);
                }
            }
        }

        protected void validator_same_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (drp_dwn_start.SelectedItem.ToString() == drp_dwn_destination.SelectedItem.ToString())
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void clearTextBox(object sender, EventArgs e)
        {
            txt_box_journey.Text = "";
        }
    }
}