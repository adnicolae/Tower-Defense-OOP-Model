using System;
using System.Collections.Generic;
using System.Text;

namespace DefenseObject
{
    class Path
    {
        private MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }
        
        public bool IsOnPath(MapLocation location)
        {
            foreach(var pathLocation in _path)
            {
                if (location.Equals(pathLocation))
                {
                    return true;
                }
            }
            return false;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            // avoid this exception
            //try
            //{
            //    return _path[pathStep];
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    return null;
            //}

            // replace with turnary if operator
            //if (pathStep < _path.Length)
            //{
            //    return _path[pathStep];
            //}
            //else
            //{
            //    return null;
            //}

            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}
