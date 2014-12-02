using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using RoutePlanner.Network;
using RoutePlanner.Main.Dijkstra;

namespace RoutePlanner.Data
{
    public interface IStorage
    {
        IDictionary<string, Line> populateLines();
        void checkNeighbours(ILine line, IDictionary<string, INode> stationMap);
    }
}
