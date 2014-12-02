using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Xml;
using RoutePlanner.Network;
using RoutePlanner.Main.Dijkstra;
using RoutePlanner.Data;

namespace RoutePlanner.Tests
{
    [TestFixture]
    public class XMLTests
    {
        private XmlDocument xmlDoc = new XmlDocument();
        private readonly string XML_FILE = "H:\\Visual Studio 2010\\Projects\\RoutePlanner\\LondonUnderground.xml";
        ILine lineCircle = new Line("Circle");
        XMLReader storage = new XMLReader();

        [Test]
        public void testXML_Reader()
        {
            init();
            XmlNode networkNode = xmlDoc.DocumentElement;
            XmlNodeList lineNodes = networkNode.ChildNodes;

            Console.WriteLine("Test - XML Reader");
                    
            //Console.WriteLine(storage.populateMap());
        }

        [Test]
        public void get_XML_Line_Name()
        {
            init();
            XmlNode networkNode = xmlDoc.DocumentElement.FirstChild;       
            string lineName = networkNode.Attributes["name"].InnerText.ToString();
            Assert.AreEqual(lineCircle.getLineName, lineName);
            Console.WriteLine(lineName);
        }

        private void init()
        {
            xmlDoc.Load(XML_FILE);
        }
    }
}
