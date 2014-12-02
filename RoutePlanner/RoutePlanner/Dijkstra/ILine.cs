using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoutePlanner.Network;

namespace RoutePlanner.Main.Dijkstra
{
    public interface ILine
    {
        IList<INode> setStationList(System.Xml.XmlNodeList xmlNodeList);
        string getLineName { get; }
        string setLineName { set; }
        IList<INeighbour> getNeighbourList { get; }
        void addStation(INode station);
        IList<INode> getNodeList { get; }
        INode getStation(string station);
    }
}
