using System;

namespace DefenseObject
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
                MapLocation[] path = {
                    new MapLocation(0, 2, map),
                    new MapLocation(0, 2, map),
                    new MapLocation(0, 2, map),
                    new MapLocation(0, 2, map),
                    new MapLocation(0, 2, map),
                    new MapLocation(0, 2, map),
                    new MapLocation(0, 2, map),
                };

                
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
                Console.WriteLine("Unhandled Exception");
            }

            
        }
    }
}