using System;
using System.Collections.Generic;
using System.Text;
using DefenseObject;

namespace TowerDefense
{
    class StrongInvader : Invader
    {
        public override int Health { get; protected set; } = 4;

        public StrongInvader(Path path) : base(path)
        {

        }
    }
}
