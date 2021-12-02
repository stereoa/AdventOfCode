using AdventOfCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Solutions.Year2021
{

    class Day02 : ASolution
    {
        public Submarine Submarine{ get; set; }
        public IEnumerable<SubmarineInstruction> Instructions { get; }
        public Day02() : base(02, 2021, "Dive!")
        {
            Instructions = Input.SplitByNewline().Select(i => new SubmarineInstruction(i));
        }

        protected override string SolvePartOne()
        {
            Submarine = new Submarine();
            Submarine.Pilot(Instructions);
            var result = Submarine.X * Submarine.Y;
            return result.ToString();
        }

        protected override string SolvePartTwo()
        {
            Submarine = new Submarine();
            Submarine.Pilot(Instructions, true);
            var result = Submarine.X * Submarine.Y;
            return result.ToString();
        }
    }
}
