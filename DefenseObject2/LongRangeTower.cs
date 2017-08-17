using System;
using System.Collections.Generic;
using System.Text;
using DefenseObject;

namespace TowerDefense
{
    class LongRangeTower : Tower
    {
        protected override int Range { get; } = 2;
        public LongRangeTower(MapLocation location) : base(location)
        { }
    }
}
