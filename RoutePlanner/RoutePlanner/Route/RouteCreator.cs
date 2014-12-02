using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoutePlanner.Main.Dijkstra;

namespace RoutePlanner.Route
{
    public class RouteCreator
    {
        private IDictionary<string, List<IEdge>> predecessors;
        private INode startNode;
        private INode endNode;
        
        public RouteCreator(IDictionary<string, List<IEdge>> legs, INode start, INode destination)
        {
            this.predecessors = legs;
            this.startNode = start;
            this.endNode = destination;
        }

        public List<List<IEdge>> buildRoute()
        {
            List<List<IEdge>> completeRoutes = new List<List<IEdge>>();
            string currentName = endNode.getName;
            List<IEdge> shortestRouteList = new List<IEdge>();
            Stack<AlternatePath> pathStack = new Stack<AlternatePath>();
            List<IEdge> routeList = new List<IEdge>();
            AlternatePath alternatePath;
            int edgeNum = 0;
            bool isStart = true;
            bool stackCheck = false;

            while (pathStack.Count > 0 || isStart)
            {
                isStart = false;

                if (pathStack.Count > 0)
                {
                    alternatePath = pathStack.Pop();
                    routeList = alternatePath.getRouteList;
                    shortestRouteList = alternatePath.getShortestRouteList;
                    edgeNum = alternatePath.getEdgeNum;
                    currentName = alternatePath.getSplitStation;
                    stackCheck = true;
                }

                while (startNode.getName != currentName)
                {
                    if (stackCheck == false)
                    {
                        routeList = predecessors[currentName];
                    }

                    if (routeList.Count > 1 && stackCheck == false)
                    {
                        for (int i = 1; i < routeList.Count; i++)
                        {
                            List<IEdge> shortListCopy = new List<IEdge>(shortestRouteList);
                            AlternatePath aPath = new AlternatePath(routeList, shortListCopy, i, currentName);
                            pathStack.Push(aPath);        
                        }
                        edgeNum = 0;
                    }
                                    
                    shortestRouteList.Add(routeList[edgeNum]);
                    currentName = routeList[edgeNum].getCurrentNode.getName;
                    if (stackCheck == true)
                    {
                        edgeNum = 0;
                        stackCheck = false;
                    }
                }
                completeRoutes.Add(shortestRouteList);
            }
            return completeRoutes;
        }// close buildRoute
    }// close class
}// close namespace
