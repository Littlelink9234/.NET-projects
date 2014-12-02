using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoutePlanner.Network;
using RoutePlanner.Main.Dijkstra;
using System.Collections;

namespace RoutePlanner.Main.Dijkstra
{
    public class DijkstraEngine
    {   
        private readonly IDictionary<INode, int> shortestDistances = new Dictionary<INode, int>();
        private readonly IDictionary<string, List<IEdge>> predecessors = new Dictionary<string, List<IEdge>>(); 
        private readonly List<INode> unsettledNodes = new List<INode>();
        private readonly ISet<INode> settledNodes = new HashSet<INode>();
        private readonly int INFINITE_DISTANCE = -1;

        public IDictionary<string, List<IEdge>> execute(INode start, INode destination)
        {
            init(start);
            INode currentNode;
            while ((currentNode = extractMin()) != null && (currentNode != destination))
            {
                markSettled(currentNode);
                relaxNeighbours(currentNode);
            }
            return predecessors;
        }

        private void init(INode start)
        {
            settledNodes.Clear();
            unsettledNodes.Clear();
            shortestDistances.Clear();
            predecessors.Clear();
            setShortestDistance(start, 0);
        }

        private void relaxNeighbours(INode currentNode)
        {
            List<INeighbour> neighbours = currentNode.getNeighbours;
            foreach (INeighbour neighbour in neighbours)
            {
                INode nextNode = neighbour.getNode;
                int weight = neighbour.getWeight;
                if(!isSettled(nextNode))
                {
                    int shortestDistance = getShortestDistance(nextNode);
                    int newShortestDistance = getShortestDistance(currentNode) + weight;
                    if(shortestDistance >= newShortestDistance || shortestDistance == -1)
                    {
                        setShortestDistance(nextNode, newShortestDistance);
                        setPredecessor(nextNode.getName, new Leg(currentNode, nextNode, neighbour.getLine, weight));
                    }
                }
            }
        }

        private void markSettled(INode node)
        {
            settledNodes.Add(node);
        }

        private int getShortestDistance(INode node)
        {
            if (shortestDistances.ContainsKey(node))
            {
                int shortestDistance = shortestDistances[node];
                return shortestDistance;
            }
            else
            {
                return INFINITE_DISTANCE;
            }
        }

        private void setPredecessor(string nodeName, IEdge leg)
        {
            List<IEdge> list;

            if (predecessors.ContainsKey(nodeName))
            {
                list = predecessors[nodeName];
                list.Add(leg);
            }
            else
            {
                list = new List<IEdge>();
                list.Add(leg);
                predecessors[nodeName] = list;
            }
        }

        private Boolean isSettled(INode node)
        {
            return settledNodes.Contains(node);
        }

        private INode extractMin()
        {
            INode min = unsettledNodes.First();
            unsettledNodes.Remove(min);
            return min;
        }

        private void setShortestDistance(INode node, int distance)
        {
            unsettledNodes.Remove(node);
            if (!shortestDistances.ContainsKey(node))
            {
                shortestDistances.Add(node, distance);
            }
                    
            unsettledNodes.Add(node);
            unsettledNodes.Sort(Compare);
        }

        private int Compare(INode first, INode second)
        {
            int result = getShortestDistance(first) - getShortestDistance(second);

            if (result == 0)
            {
                return first.Compare(first, second);
            }
            return result;
        }
    }
}