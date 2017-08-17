using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    public class Map
    {
        // width and height cannot change after creation
        // readonly ensures the values won't be changed at a later point
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;          
        }
    }
}
