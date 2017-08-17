using System;
using System.Collections.Generic;
using System.Text;
using DefenseObject;

namespace DefenseObject2
{
    class PowerfulTower : Tower
    {
        protected override int Power { get; } = 2;
        public PowerfulTower(MapLocation location) : base(location) { }
    }
}
