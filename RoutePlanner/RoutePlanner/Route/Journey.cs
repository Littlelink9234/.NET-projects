using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoutePlanner.Network;
using RoutePlanner.Main.Dijkstra;

namespace RoutePlanner.Route
{
    public class Journey
    {
        INode startNode;
        INode endNode;
        List<List<IEdge>> shortestRouteList;
        private string journeyStart;
        private string journeyEnd;
        private string journeyInfo;

        public Journey(INode startStation, INode endStation, List<List<IEdge>> shortestRoutes)
        {
            this.startNode = startStation;
            this.endNode = endStation;
            this.shortestRouteList = shortestRoutes;
        }

        public List<RouteOutput> writeAllJourneys()
        {
            List<RouteOutput> routeList = new List<RouteOutput>();

            for (int i = 0; i < shortestRouteList.Count; i++)
            {
                routeList.Add(writeJourney(shortestRouteList[i]));
            }
            return routeList;
        }

        public RouteOutput writeJourney(List<IEdge> shortestPath)
        {  
            int currentStops = 0;
            int totalStops = 0;
            int lineChangeCounter = 0;
            string currentLineName = shortestPath[shortestPath.Count-1].getLine;
            string currentNode = shortestPath[shortestPath.Count-1].getCurrentNode.getName;

            journeyInfo = "";
            journeyStart = "Journey: \r\n\tStart: \t" + startNode.getName + "\r\n";
            journeyEnd = "\tEnd: \t" + endNode.getName + "\r\n" + "\r\nDetails: ";

            for (int i = shortestPath.Count - 1; i >= 0; i--)
            {
                currentStops++;
                
                if (i == 0)
                {
                    journeyInfo += "From " + currentNode + " take the " + shortestPath[i].getLine +
                                    " line to " + shortestPath[i].getNextNode.getName + " for " + currentStops + " stop(s).\r\n";
                }
                else if (currentLineName != shortestPath[i-1].getLine)
                {
                    //this code occurs when there is ONLY a line change.
                    journeyInfo += "From " + currentNode + " take the " + shortestPath[i].getLine + " line to "
                                        + shortestPath[i-1].getCurrentNode.getName + " for " + currentStops + " stop(s).\r\n";
                    currentStops = 0;
                    currentLineName = shortestPath[i-1].getLine;
                    currentNode = shortestPath[i-1].getCurrentNode.getName;
                    lineChangeCounter++;
                }
                totalStops++;
            }
            return new RouteOutput(journeyStart, journeyEnd, journeyInfo, lineChangeCounter, totalStops);
        }
    }
}