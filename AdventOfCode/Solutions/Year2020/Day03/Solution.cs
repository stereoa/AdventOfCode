using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Solutions.Year2020
{

    class Day03 : ASolution
    {
        public Map Map { get; }

        public Day03() : base(03, 2020, "")
        {
            Map = ParseMap(Input);
        }


        protected override string SolvePartOne()
        {
            return CalculateSlopeCollisions(3,1).ToString();
        }

        protected override string SolvePartTwo()
        {
            var slopes = new List<Slope>();
            slopes.Add(new Slope(1,1));
            slopes.Add(new Slope(3,1));
            slopes.Add(new Slope(5,1));
            slopes.Add(new Slope(7,1));
            slopes.Add(new Slope(1,2));

            var collisionCounts = new List<uint>();
            foreach(var slope in slopes)
            {
                collisionCounts.Add((uint)CalculateSlopeCollisions(slope.X, slope.Y));
            }
            var total = collisionCounts.Aggregate((x, y) => x * y);
            return total.ToString();
        }

        private int CalculateSlopeCollisions(int slopeX, int slopeY)
        {
            var treeCount = 0;
            var x = slopeX;
            for (var y = slopeY; y < Map.Height; y+=slopeY)
            {
                if (Map.Tiles[x, y] is TreeTile)
                {
                    treeCount++;
                }
                x += slopeX;
                if (x > Map.Width - 1)
                {
                    x -= Map.Width;
                }
            }
            return treeCount;
        }

        private Map ParseMap(string input)
        {
            var lines = input.Split("\n");
            var map = new Map(lines[0].Length, lines.Length);
            var y = 0;
            foreach (var line in lines)
            {
                for (var x = 0; x < map.Width; x++)
                {
                    if (line[x] == '.')
                    {
                        map.Tiles[x, y] = new EmptyTile();
                    }
                    else if (line[x] == '#')
                    {
                        map.Tiles[x, y] = new TreeTile();
                    }
                }
                y++;
            }
            return map;
        }

    }
}
