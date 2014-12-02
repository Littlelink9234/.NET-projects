using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Windows.Forms;
using System.Configuration;
using RoutePlanner.Main.Dijkstra;
using RoutePlanner.Network;
using RoutePlanner.Route;
using RoutePlanner.Data;

namespace RoutePlanner.Main
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            RouteController controller;
            String DATA_SELECTION = "dataXML";
            AppSettingsReader appReader = new AppSettingsReader();
            string datastore = (string)appReader.GetValue(DATA_SELECTION, typeof(string));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                controller = new RouteController();
                Application.Run(new RouteForm(controller));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
