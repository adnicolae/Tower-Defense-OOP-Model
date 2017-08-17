using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class PowerfulTower : Tower
    {
        protected override int Power { get; } = 2;
        public PowerfulTower(MapLocation location) : base(location) { }
    }
}
