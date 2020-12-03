using System.Linq;

namespace AdventOfCode.Solutions.Year2020
{

    public class Day01 : ASolution
    {
        public const int GOAL = 2020;
        public const string NO_MATCH_MESSAGE = "No match found!";

        public int[] Expenses { get; set; }

        public Day01() : base(01, 2020, "")
        {
            Expenses = Input.ToIntArray();
        }


        protected override string SolvePartOne()
        {
            for (var i = 0; i < Expenses.Count() - 2; i++)
            {
                var firstNumber = Expenses[i];
                for (var j = i + 1; j < Expenses.Count() - 1; j++)
                {
                    var secondNumber = Expenses[j];
                    if (firstNumber + secondNumber == GOAL)
                    {
                        return (firstNumber * secondNumber).ToString();
                    }
                }
            }
            return NO_MATCH_MESSAGE;
        }

        protected override string SolvePartTwo()
        {
            for (var i = 0; i < Expenses.Count() - 3; i++)
            {
                var firstNumber = Expenses[i];
                for (var j = i + 1; j < Expenses.Count() - 2; j++)
                {
                    var secondNumber = Expenses[j];
                    for (var k = j + 1; k < Expenses.Count() - 1; k++)
                    {
                        var thirdNumber = Expenses[k];

                        if (firstNumber + secondNumber + thirdNumber == GOAL)
                        {
                            return (firstNumber * secondNumber * thirdNumber).ToString();
                        }
                    }
                }
            }
            return NO_MATCH_MESSAGE;
        }
    }
}
