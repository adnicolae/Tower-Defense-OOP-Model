using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = .9;
        protected override int Range { get; } = 2;
        public SniperTower(MapLocation location) : base(location) { }
    }
}
