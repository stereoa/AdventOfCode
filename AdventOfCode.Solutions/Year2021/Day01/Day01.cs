using AdventOfCode.Models;
using System;
using System.Linq;

namespace AdventOfCode.Solutions.Year2021
{

    class Day01 : SolutionBase
    {
        public SonarSweep SonarSweep { get; set; }

        public Day01() : base(01, 2021, "Sonar Sweep")
        {
            SonarSweep = new SonarSweep(Input.ToIntArray("\n").ToList());
        }


        protected override string SolvePartOne()
        {
            return SonarSweep.GetIncreaseCount(SonarSweep.Measurements)
                             .ToString();
        }

        protected override string SolvePartTwo()
        {
            return SonarSweep.GetIncreaseCount(SonarSweep.Windows)
                             .ToString();
        }
    }
}
