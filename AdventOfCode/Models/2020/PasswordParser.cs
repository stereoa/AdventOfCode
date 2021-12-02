using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Models
{
    public static class PasswordParser
    {
        public static IEnumerable<Password> Parse(string input)
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