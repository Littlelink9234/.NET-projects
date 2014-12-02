using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoutePlanner.Main.Dijkstra;

namespace RoutePlanner.Network
{
    public class Line : ILine
    {
        private string lineName;
        private IList<INode> stationList = new List<INode>();
        private IList<INeighbour> neighbourList = new List<INeighbour>();

        public Line(string lineName)
        {
            this.lineName = lineName;
        }

        public string getLineName
        {
            get { return lineName; }
        }

        public string setLineName
        {
            set { lineName = value; }
        }

        public IList<INeighbour> getNeighbourList
        {
            get { return neighbourList; }
        }

        public void addStation(INode station)
        {
            stationList.Add(station);
        }

        public IList<INode> getNodeList
        {
            get { return stationList; }
        }
        
        public INode getStation(string station)
        {
            foreach (INode node in stationList)
            {
                if (node.getName == station)
                {
                    return node;
                }
            }
            return null;
        }

        public IList<INode> setStationList(System.Xml.XmlNodeList xmlNodeList)
        {
            foreach (INode station in xmlNodeList)
            {
                stationList.Add(station);
            }
            return stationList;
        }
    }
}
