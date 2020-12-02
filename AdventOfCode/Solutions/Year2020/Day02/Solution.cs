using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode.Solutions.Year2020
{

    class Day02 : ASolution
    {
        public IEnumerable<Password> Passwords { get; }

        public Day02() : base(02, 2020, "")
        {
            Passwords = ParsePasswords(Input);
        }

        protected override string SolvePartOne()
        {
            return Passwords.Count(p => p.IsValidCharCount).ToString();
        }

        protected override string SolvePartTwo()
        {
            return Passwords.Count(p => p.IsValidCharPositioning).ToString();
        }

        private IEnumerable<Password> ParsePasswords(string input)
        {
            var regex = new Regex(@"(\d+)-(\d+) (.+): (.+)");
            return regex.Matches(input).Select(m => new Password
            {
                Min = int.Parse(m.Groups[1].Value),
                Max = int.Parse(m.Groups[2].Value),
                Character = m.Groups[3].Value[0],
                Content = m.Groups[4].Value
            });
        }
    }
}
