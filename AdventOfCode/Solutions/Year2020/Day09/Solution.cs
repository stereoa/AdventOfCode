using AdventOfCode.Models;

namespace AdventOfCode.Solutions.Year2020
{

    class Day09 : ASolution
    {

        public Day09() : base(09, 2020, "")
        {

        }

        protected override string SolvePartOne()
        {
            return new XmasEncryption(Input, 25).Weakpoint.ToString();
        }

        protected override string SolvePartTwo()
        {
            return null;
        }
    }
}
