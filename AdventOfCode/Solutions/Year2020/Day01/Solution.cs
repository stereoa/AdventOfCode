using AdventOfCode.Models;

namespace AdventOfCode.Solutions.Year2020
{

    public class Day01 : ASolution
    {
        public const int GOAL = 2020;

        public ExpenseReport Report { get; set; }

        public Day01() : base(01, 2020, "")
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
