using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using RoutePlanner.Data;
using RoutePlanner.Route;
using RoutePlanner.Network;

namespace RoutePlanner.Main.Dijkstra
{
    public class RouteController
    {
        private XMLReader storage;
        private DijkstraEngine dijkstraEngine = new DijkstraEngine();
        private INetwork graph;
        private RouteCreator routeCreator;
        private Journey journey;
        RouteOutputComparer comparer = new RouteOutputComparer();

        public RouteController()
        {
            try
            {      
                storage = new XMLReader();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            graph = new Graph(storage.populateLines());
        }

        public List<RouteOutput> startDijkstra(string start, string destination)
        {
            INode startNode = graph.getNode(start);
            INode endNode = graph.getNode(destination);
            IDictionary<string, List<IEdge>> legs = dijkstraEngine.execute(startNode, endNode);

            routeCreator = new RouteCreator(legs, startNode, endNode);
            journey = new Journey(startNode, endNode, routeCreator.buildRoute());
            return printMinLineChanges(journey.writeAllJourneys());
        }

        public ISet<string> getNodes()
        {
            return graph.getAllNodes();
        }

        private List<RouteOutput> printMinLineChanges(List<RouteOutput> outputList)
        {
            outputList.Sort(comparer);
            int minLinechanges = outputList[0].numOfLineChanges;
            int current = 0;
            List<RouteOutput> minOutputList = new List<RouteOutput>();

            while (current < outputList.Count && minLinechanges == outputList[current].numOfLineChanges)
            {
                minOutputList.Add(outputList[current]);
                current++;
            }
            return minOutputList;
        }
    }
}