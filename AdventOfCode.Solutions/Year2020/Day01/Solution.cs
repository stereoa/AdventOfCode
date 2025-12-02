using AdventOfCode.Models;
using AdventOfCode.Solutions;

namespace AdventOfCode.AdventOfCode.Solutions.Year2020.Day01
{

    class Day01 : SolutionBase
    {
        public const int GOAL = 2020;

        public ExpenseReport Report { get; set; }

        public Day01() : base(01, 2020, "Report Repair")
        {
            Report = new ExpenseReport(Input.ToIntArray("\n"), GOAL);
        }


        protected override string SolvePartOne()
        {
            return Report.FindPair();
        }

        protected override string SolvePartTwo()
        {
            return Report.FindTriple();
        }
    }
}
