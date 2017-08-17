using System;
using System.Collections.Generic;
using System.Text;
using DefenseObject;

namespace DefenseObject2
{
    class BasicInvader : Invader
    {
        public override int Health { get; protected set; } = 2;
        // does just what the BaseInvader does
        public BasicInvader(Path path) : base(path)
        {

        }
    }
}
