using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode.Solutions.Year2020
{

    class Day01 : ASolution
    {

        public Day01() : base(01, 2020, "")
        {

        }

        protected override string SolvePartOne()
        {
            var goal = 2020;
            var lines = Input.Split("\n");
            var firstNumber = 0;
            var secondNumber = 0;
            var numbers = lines.Select(l => int.Parse(l)).ToArray();
            var keepGoing = true;
            for (var i = 0; i < numbers.Count() - 2; i++)
            {
                firstNumber = numbers[i];
                for (var j = i + 1; j < numbers.Count() - 1; j++)
                {
                    secondNumber = numbers[j];
                    if (firstNumber + secondNumber == goal)
                    {
                        keepGoing = false;
                        break;
                    }
                }
                if(!keepGoing)
                {
                    break;
                }
            }
            return (firstNumber * secondNumber).ToString();
        }

        protected override string SolvePartTwo()
        {
            return null;
        }
    }
}
