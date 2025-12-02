using AdventOfCode.Models;
using AdventOfCode.Solutions;

namespace AdventOfCode.AdventOfCode.Solutions.Year2020.Day04
{

    class Day04 : SolutionBase
    {

        public Day04() : base(04, 2020, "")
        {
            Passports = PassportParser.Parse(Input);
        }

        public IEnumerable<Passport> Passports { get; }

        protected override string SolvePartOne()
        {
            return Passports.Count(p => p.HasValidFields).ToString();
        }

        protected override string SolvePartTwo()
        {
            return Passports.Count(p => p.HasValidData && p.HasValidFields).ToString();
        }
    }
}
