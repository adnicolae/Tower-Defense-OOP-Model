using System;
using System.Collections.Generic;
using System.Text;

namespace DefenseObject
{
    // inheritence in C#
    class MapLocation : Point
    {
        // base class is the parent class
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + ", " + y + " is not on this map.");
            }
        }
    }
}
