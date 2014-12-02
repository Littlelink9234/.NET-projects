using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RoutePlanner.Network;

namespace RoutePlanner.Tests
{
    public class StationTests
    {
        private readonly String STATION_NAME = "Stockwell";
        Station testStation = new Station("Stockwell");

        [Test]
        public void getNameTest()
        {
            Console.WriteLine("Test - Get Name");
            String result = testStation.getName;
            Assert.AreEqual(result, STATION_NAME);
            Console.WriteLine(result);
        }

        [Test]
        public void CompareTwoStations()
        {
            Console.WriteLine("Test - Comparing Two Stations");
        }
    }
}
