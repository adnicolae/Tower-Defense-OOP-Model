using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
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
