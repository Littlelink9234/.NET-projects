using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoutePlanner.Main.Dijkstra
{
    public interface INeighbour
    {
        int getWeight { get; }
        INode getNode { get; }
        string getLine { get; }
        string setLine { set; }
    }
}
