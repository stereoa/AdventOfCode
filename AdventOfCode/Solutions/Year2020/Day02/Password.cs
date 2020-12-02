using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Solutions.Year2020
{
    public class Password
    {
        public Password(int min, int max, char character, string content)
        {
            Min = min;
            Max = max;
            Character = character;
            Content = content;
        }

        public int Min { get; set; }
        public int Max { get; set; }
        public char Character { get; set; }
        public string Content { get; set; }
        public bool IsValidCharCount
        {
            get
            {
                var count = Content.Count(c => c == Character);
                return count >= Min && count <= Max;
            }
        }

        public bool IsValidCharPositioning
        {
            get
            {
                var minChar = Content[Min - 1];
                var maxChar = Content[Max - 1];
                return (minChar == Character && maxChar != Character) ||
                       (minChar != Character && maxChar == Character);
            }
        }
    }
}
