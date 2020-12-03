using AdventOfCode.Models;
using System.Collections.Generic;

namespace AdventOfCode.Solutions.Year2020
{

    class Day03 : ASolution
    {
        public Map Map { get; }

        public Day03() : base(03, 2020, "")
        {
            Map = new Map(Input);
        }

        protected override string SolvePartOne()
        {
            var slope = new Slope(3, 1);
            return Map.CalculateSlopeCollisions(slope).ToString();
        }

        protected override string SolvePartTwo()
        {
            var slopes = new List<Slope>();
            slopes.Add(new Slope(1, 1));
            slopes.Add(new Slope(3, 1));
            slopes.Add(new Slope(5, 1));
            slopes.Add(new Slope(7, 1));
            slopes.Add(new Slope(1, 2));
            return Map.CalculateCollisions(slopes).ToString();
        }
    }
}
