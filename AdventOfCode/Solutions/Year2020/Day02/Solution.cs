using AdventOfCode.Models;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Solutions.Year2020
{

    class Day02 : ASolution
    {
        public IEnumerable<Password> Passwords { get; }

        public Day02() : base(02, 2020, "")
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
