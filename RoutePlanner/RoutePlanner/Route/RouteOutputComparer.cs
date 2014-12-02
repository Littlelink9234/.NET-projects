using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoutePlanner.Route
{
    public class RouteOutputComparer : Comparer<RouteOutput>
    {
        public override int Compare(RouteOutput routeOutputOne, RouteOutput routeOutTwo)
        {
            if(routeOutputOne.numOfLineChanges.CompareTo(routeOutTwo.numOfLineChanges) != 0)
            {
                return routeOutputOne.numOfLineChanges.CompareTo(routeOutTwo.numOfLineChanges);
            }
            else
            {
                return 0;
            }   
        }
    }
}
