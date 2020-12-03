using System.Linq;

namespace AdventOfCode.Models
{
    public class ExpenseReport
    {
        public const string NO_MATCH_MESSAGE = "No match found!";

        public int[] Expenses;
        public int Goal { get; }

        public ExpenseReport(int[] expenses, int goal)
        {
            Expenses = expenses;
            Goal = goal;
        }

        public string FindPair()
        {
            for (var i = 0; i < Expenses.Count() - 2; i++)
            {
                var firstNumber = Expenses[i];
                for (var j = i + 1; j < Expenses.Count() - 1; j++)
                {
                    var secondNumber = Expenses[j];
                    if (firstNumber + secondNumber == Goal)
                    {
                        return (firstNumber * secondNumber).ToString();
                    }
                }
            }
            return NO_MATCH_MESSAGE;
        }

        internal string FindTriple()
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

                        if (firstNumber + secondNumber + thirdNumber == Goal)
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