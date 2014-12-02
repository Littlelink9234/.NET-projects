using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoutePlanner.Main.Dijkstra;

namespace RoutePlanner.Network
{
    public class Station : INode
    {
        private string name;
        private List<INeighbour> neighbourList = new List<INeighbour>();
        private List<ILine> lineList = new List<ILine>();

        public Station(string name)
        { 
            this.name = name;
        }

        public String getName
        {
            get { return name; }
        }

        public List<INeighbour> getNeighbours
        {
            get { return neighbourList; }
        }

        public void addNeighbour(INeighbour neighbour)
        {
            if (!neighbourList.Contains(neighbour))
            {
                neighbourList.Add(neighbour);
            }
        }

        public List<ILine> getAllLines
        {
            get { return lineList; }
        }
 
        public void addLine(ILine line)
        {
            lineList.Add(line);
        }

        public override Boolean Equals(Object station)
        {
            return name == ((Station)station).getName;
        }

        public int Compare(INode first, INode second)
        {
            return first.getName.CompareTo(second.getName);
        }
    }
}
