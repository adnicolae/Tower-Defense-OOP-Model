using System;
using System.Collections.Generic;
using System.Text;
using DefenseObject;

namespace DefenseObject2
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = .9;
        protected override int Range { get; } = 2;
        public SniperTower(MapLocation location) : base(location) { }
    }
}
