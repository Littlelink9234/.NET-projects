using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoutePlanner.Main.Dijkstra;

namespace RoutePlanner.Route
{
    public class AlternatePath
    {
        private List<IEdge> routeList;
        private List<IEdge> shortestRouteList;
        private int edgeNum;
        private string stationSplit;

        public AlternatePath(List<IEdge> listOfRoutes, List<IEdge> listOfShortPaths, int numOfEdges, string splitStation)
        {
            this.routeList = listOfRoutes;
            this.shortestRouteList = listOfShortPaths;
            this.edgeNum = numOfEdges;
            this.stationSplit = splitStation;
        }

        public List<IEdge> getRouteList
        {
            get { return routeList; }
        }

        public List<IEdge> getShortestRouteList
        {
            get { return shortestRouteList; }
        }

        public int getEdgeNum
        {
            get { return edgeNum; }
        }

        public string getSplitStation
        {
            get { return stationSplit; }
        }
    }
}
