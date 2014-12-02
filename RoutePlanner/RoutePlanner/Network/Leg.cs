using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoutePlanner.Main.Dijkstra;

namespace RoutePlanner.Network
{
    public class Leg : IEdge
    {
        private readonly INode currentNode;
        private readonly INode nextNode;
        private readonly string line;
        private readonly int weight;

        public Leg(INode currentNode, INode nextNode, string line, int weight)
        {
            this.currentNode = currentNode;
            this.nextNode = nextNode;
            this.line = line;
            this.weight = weight;
        }

        public INode getCurrentNode
        {
            get { return currentNode; }
        }

        public INode getNextNode
        {
            get { return nextNode; }
        }

        public string getLine
        {
            get { return line; }
        }

        public int getWeight
        {
            get { return weight; }
        }
    }
}
