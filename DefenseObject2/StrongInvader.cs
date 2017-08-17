using System;
using System.Collections.Generic;
using System.Text;
using DefenseObject;

namespace DefenseObject2
{
    class StrongInvader : Invader
    {
        public override int Health { get; protected set; } = 4;

        public StrongInvader(Path path) : base(path)
        {

        }
    }
}
