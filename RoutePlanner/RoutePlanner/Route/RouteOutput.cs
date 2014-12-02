using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoutePlanner.Route
{
    public class RouteOutput
    {
        private int lineChanges;
        private int totalStops;
        private string startJourney;
        private string endJourney;
        private string infoJourney;

        public RouteOutput(string journeyStart, string journeyEnd, string journeyInfo, int changes, int stops)
        {
            this.startJourney = journeyStart;
            this.endJourney = journeyEnd;
            this.infoJourney = journeyInfo;
            this.lineChanges = changes;
            this.totalStops = stops;
        }

        public string journeyStart
        {
            get { return startJourney; }
        }

        public string journeyEnd
        {
            get { return endJourney; }
        }

        public string journeyInfo
        {
            get { return infoJourney; }
        }

        public int numOfLineChanges
        {
            get { return lineChanges; }
        }

        public int numOfStops
        {
            get { return totalStops; }
        }
    }
}
