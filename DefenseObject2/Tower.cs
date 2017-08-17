using System;
using System.Collections.Generic;
using System.Text;
using DefenseObject2;

namespace TowerDefense
{
    class Tower
    {
        // string[] smth = {"sunshine", "sun", "hello"};
        // array.Length
        private readonly MapLocation _location;
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        //private static readonly Random _random = new Random();


        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return DefenseObject2.Random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(IInvader[] invaders)
        {

            foreach (IInvader i in invaders)
            {
                if (i.IsActive && _location.InRangeOf(i.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        i.DecreaseHealth(Power);
                        
                        if (i.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader at " + i.Location);
                        }
                    }
                    break; // exit when an enemy was shot
                }
            }
        }
    }
}