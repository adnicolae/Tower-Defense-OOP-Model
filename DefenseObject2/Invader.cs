using System;
using System.Collections.Generic;
using System.Text;
using DefenseObject;
using DefenseObject2;

namespace TowerDefense
{
    // : IInvader means Invader implements IInvader
    abstract class Invader : IInvader
    {
        //private MapLocation _location;

        // Methods
        /*
        public MapLocation GetLocation()
        {
            return _location;
        }

        public void SetLocation(MapLocation value)
        {
            _location = value;
        }
        */

        // Properties
        // private get -- other classes will only be able to set the location; methods and stuff in the Invader Class will be able to get it 
        // private set -- is usually used so that methods in other classes can get the attribute but not set it
        /*
        public MapLocation Location
        {
            get // other classes will on
            {
                return _location;
            }
            private set
            {
                _location = value;
            }
        }
        */

        // replace the above:

        private readonly Path _path;
        
        private int _pathStep = 0;

        /*
        public MapLocation Location { get; private set; }

        public Invader(Path path)
        {
            _path = path;
            Location = _path.GetLocationAt(_pathStep);
        }

        public void Move()
        {
            _pathStep++;
            Location = _path.GetLocationAt(_pathStep);
        }
        */

        // Since we update the location twice in the above code
        // replace using computed properties:
        /*
        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }
        */

        // syntactic sugar:
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        // abstract - must be overridden in subclasses
        public abstract int Health { get; protected set; }

        protected virtual int StepSize { get; } = 1; // get { return 1; } - protected to be accessed by subclasses

        // True if the invader has reached the end of the path
        public bool HasScored
        {
            get
            {
                return _pathStep >= _path.Length;
            }
        }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            Console.WriteLine("Shot at and hit an invader!");
        }
    }
}
