using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{   
    // Polymorphism - own implementation of DecreaseHealth
    // by adding 'virtual' in Invader Class we can provide 
    // own implementation of DecreaseHealth in ShieldedInvader
    class ShieldedInvader : Invader
    {
        public override int Health { get; protected set; } = 2;
        //private static Random _random = new Random(); // returns random btw 0 and 1

        public ShieldedInvader(Path path) : base(path)
        {

        }

        public override void DecreaseHealth(int factor)
        {
            if (Random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at a shielded invader but it sustained damage!");
            }
        }
    }
}
