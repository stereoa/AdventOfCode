using AdventOfCode.Models;

namespace AdventOfCode.Solutions.Year2020
{

    class Day09 : ASolution
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
