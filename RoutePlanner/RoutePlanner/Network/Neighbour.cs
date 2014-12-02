using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoutePlanner.Main.Dijkstra;

namespace RoutePlanner.Network
{
    public class Neighbour : INeighbour
    {
        private int weight = 1;
        private INode node;
        private string line = "";

        public Neighbour(INode node)
        {
            this.node = node;
        }

        public int getWeight
        {
            get { return weight; }
        }

        public INode getNode
        {
            get { return node; }
        }

        public string getLine
        {
            get { return line; }
        }

        public string setLine
        {
            set { line = value; }
        }

        public override Boolean Equals(Object neighbour)
        {
            Neighbour nextNode = (Neighbour)neighbour;
            return weight == nextNode.getWeight && line == nextNode.getLine && node.Equals((Station)nextNode.getNode);
        }
    }
}
