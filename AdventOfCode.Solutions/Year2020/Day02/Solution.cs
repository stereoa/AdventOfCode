using AdventOfCode.Models;
using AdventOfCode.Solutions;

namespace AdventOfCode.AdventOfCode.Solutions.Year2020.Day02
{

    class Day02 : SolutionBase
    {
        public IEnumerable<Password> Passwords { get; }

        public Day02() : base(02, 2020, "Password Philosophy")
        {
            Passwords = PasswordParser.Parse(Input);
        }

        protected override string SolvePartOne()
        {
            return Passwords.Count(p => p.IsValidCharCount).ToString();
        }

        protected override string SolvePartTwo()
        {
            return Passwords.Count(p => p.IsValidCharPositioning).ToString();
        }
    }
}
