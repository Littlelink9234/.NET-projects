using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoutePlanner.Main.Dijkstra;

namespace RoutePlanner.Network
{
    public class Graph : INetwork
    {
        private IDictionary<string, Line> graph = new Dictionary<string, Line>();

        public Graph(IDictionary<string, Line> lineDict)
        {
            this.graph = lineDict;
        }

        public void addLine(Line line)
        {
            graph.Add(line.getLineName, line);
        }

        public bool contains(string lineName)
        {
            if(graph.ContainsKey(lineName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public INode getNode(string stationName)
        {
            foreach (KeyValuePair<string, Line> line in graph)
            {
                INode node = line.Value.getStation(stationName);
                if (node != null)
                {
                    return node;
                }
            }
            return null;
        }

        public ISet<string> getAllNodes()
        {
            ISet<string> lineSet = new SortedSet<string>();
            foreach (KeyValuePair<string, Line> line in graph)
            {
                for (int i = 0; i < line.Value.getNodeList.Count; i++)
                {
                    lineSet.Add(line.Value.getNodeList[i].getName);
                }
            }
            return lineSet;
        }
    }
}
