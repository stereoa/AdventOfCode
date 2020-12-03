using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Solutions.Year2020
{
    class Map
    {
        public MapTile[,] Tiles { get; set; }
        public int Width { get; }
        public int Height { get; }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            Tiles = new MapTile[width, height];
        }
    }
}
