using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoutePlanner.Network;

namespace RoutePlanner.Main.Dijkstra
{
    public interface INode
    {
        string getName { get; }
        List<INeighbour> getNeighbours { get; }
        List<ILine> getAllLines { get; }
        void addLine(ILine line);
        void addNeighbour(INeighbour neighbour);
        Boolean Equals(Object station);
        int Compare(INode first, INode second);
    }
}
