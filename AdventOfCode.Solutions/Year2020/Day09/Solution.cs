using AdventOfCode.Models;
using AdventOfCode.Solutions;

namespace AdventOfCode.AdventOfCode.Solutions.Year2020.Day09
{

    class Day09 : SolutionBase
    {
        public XmasEncryption Encryption { get; }

        public Day09() : base(09, 2020, "")
        {
            Encryption = new XmasEncryption(Input, 25);
        }

        protected override string SolvePartOne()
        {
            return Encryption.Weakpoint.ToString();
        }

        protected override string SolvePartTwo()
        {
            return Encryption.Weakness.ToString();
        }
    }
}
