using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Solutions.Year2020
{

    class Day02 : ASolution
    {

        public Day02() : base(02, 2020, "")
        {

        }

        protected override string SolvePartOne()
        {
            var lines = Input.Split("\n");
            var count = 0;

            foreach(var line in lines)
            {
                var password = ParsePassword(line);

                if(password.IsValidCharCount)
                {
                    count++;
                }

            }

            return count.ToString();
        }

        protected override string SolvePartTwo()
        {
            var lines = Input.Split("\n");
            var count = 0;

            foreach (var line in lines)
            {
                var password = ParsePassword(line);

                if (password.IsValidCharPositioning)
                {
                    count++;
                }

            }

            return count.ToString();
        }

        private Password ParsePassword(string line)
        {
            var sections = line.Split(" ");

            var range = sections[0].Split("-");
            var min = int.Parse(range[0]);
            var max = int.Parse(range[1]);

            var character = sections[1].Replace(":", "")[0];

            var content = sections[2];

            return new Password(min, max, character, content);
        }

    }
}
