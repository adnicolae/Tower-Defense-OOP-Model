using System;
using DefenseObject2;

namespace TowerDefense
{
    class Game
    {
        //Methods that are called directly on a class name are static methods.
        //Hide implementation details and make objects easy to use with encapsulation.
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(new[]{
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                });

                //MapLocation location = new MapLocation(0, 2, map);
                //if (path.IsOnPath(location))
                //{
                //    Console.WriteLine(location + " is on path");
                //}

                /*
                Invader invader = new Invader();
                MapLocation location = new MapLocation(0, 0, map);

                // call the setter inside invader.Location
                invader.Location = location;

                // call the getter
                location = invader.Location;
                */

                IInvader[] invaders =
                {
                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new StrongInvader(path),
                    new BasicInvader(path),
                    new ResurrectingInvader(path)
                };

                Tower[] towers =
                {
                    new Tower(new MapLocation(1, 3, map)),
                    new Tower(new MapLocation(3, 3, map)),
                    new Tower(new MapLocation(5, 3, map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon ? "Won" : "Lost"));
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DefenseException ex)
            {
                Console.WriteLine("Unhandled DefenseException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }

            
        }
    }
}