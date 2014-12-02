using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using RoutePlanner.Main.Dijkstra;
using RoutePlanner.Network;

namespace RoutePlanner.Data
{
    public class XMLReader : IStorage
    {
        private XmlDocument xmlDoc = new XmlDocument();
        string xmlDocument = "C:\\Users\\Jason\\Documents\\FDM Group\\RoutePlanner\\CompleteTube.xml";
        string exceptionMessage = "The XML file was not found";

        public XMLReader()
        {            
            if (File.Exists(xmlDocument))
            {
                xmlDoc.Load(xmlDocument);
            }
            else
                throw new FileNotFoundException(exceptionMessage);
        }

        public IDictionary<string, Line> populateLines()
        {
            XmlNode networkNode = xmlDoc.DocumentElement;
            XmlNodeList lineNodes = networkNode.ChildNodes;
            XmlNodeList stationList;
            IDictionary<string, Line> lineMap = new Dictionary<string, Line>();
            IDictionary<string, INode> stationMap = new Dictionary<string, INode>();
            
            for (int i = 0; i < lineNodes.Count; i++)
            {
                string lineName = lineNodes[i].Attributes["name"].InnerText.ToString();
                string longLineName;

                if (lineName.IndexOf(" (") != -1)
                {
                    longLineName = lineName.Substring(0, lineName.IndexOf(" ("));
                }
                else
                {
                    longLineName = lineName;
                }

                stationList = lineNodes[i].ChildNodes;
                Line line = new Line(longLineName);           

                foreach (XmlNode node in stationList)
                {
                    INode station;
                    if(stationMap.ContainsKey(node.InnerText))
                    {
                        station = stationMap[node.InnerText];
                    }
                    else
                    {
                        station = new Station(node.InnerText);
                        stationMap.Add(node.InnerText, station);
                    }
                    line.addStation(station);
                }
                lineMap.Add(lineName, line);
                checkNeighbours(line, stationMap);
            }
            return lineMap;
        }

        public void checkNeighbours(ILine line, IDictionary<string, INode> stationMap)
        {
            for (int i = 0; i < line.getNodeList.Count; i++)
            {
                INeighbour neighborForward;
                INeighbour neighborBehind;

                if (i == 0)
                {
                    neighborForward = new Neighbour(line.getNodeList[i + 1]);
                    neighborForward.setLine = line.getLineName;
                    INode node = stationMap[line.getNodeList[i].getName];
                    node.addNeighbour(neighborForward);
                }
                else if (i == line.getNodeList.Count - 1)
                {
                    neighborBehind = new Neighbour(line.getNodeList[i - 1]);
                    neighborBehind.setLine = line.getLineName;
                    INode node = stationMap[line.getNodeList[i].getName];
                    node.addNeighbour(neighborBehind);
                }
                else
                {
                    neighborForward = new Neighbour(line.getNodeList[i + 1]);
                    neighborBehind = new Neighbour(line.getNodeList[i - 1]);
                    neighborForward.setLine = line.getLineName;
                    neighborBehind.setLine = line.getLineName;
                    INode node = stationMap[line.getNodeList[i].getName];
                    node.addNeighbour(neighborForward);
                    node.addNeighbour(neighborBehind);
                }
            }
        }
    }
}