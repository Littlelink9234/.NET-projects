using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoutePlanner.Main.Dijkstra
{
    public interface IEdge
    {
        INode getCurrentNode { get; }
        INode getNextNode { get; }
        string getLine { get; }
        int getWeight { get; }
    }
}
