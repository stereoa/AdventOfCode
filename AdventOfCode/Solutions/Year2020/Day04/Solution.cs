using AdventOfCode.Models;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Solutions.Year2020
{

    class Day04 : ASolution
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
