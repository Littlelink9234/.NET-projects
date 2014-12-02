using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoutePlanner.Network;

namespace RoutePlanner.Main.Dijkstra
{
    public interface INetwork
    {
        INode getNode(string stationName);
        void addLine(Line line);
        bool contains(string lineName);
        ISet<string> getAllNodes();
    }
}
