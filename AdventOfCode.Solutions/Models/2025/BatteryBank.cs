using System;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode.AdventOfCode.Solutions.Models
{
    public class BatteryBank
    {
        public long MaximumJoltage { get; private set; }

        public BatteryBank(string input, int batteriesToTurnOn = 2)
        {
            var digits = input.Where(char.IsDigit).Select(c => c - '0').ToList();

            var stack = new Stack<int>();
            var remaining = batteriesToTurnOn;

            for (int i = 0; i < digits.Count; i++)
            {
                var digit = digits[i];

                while (stack.Count > 0 &&
                       stack.Count + (digits.Count - i) > remaining &&
                       stack.Peek() < digit)
                {
                    stack.Pop();
                }

                if (stack.Count < remaining)
                {
                    stack.Push(digit);
                }
            }

            var selectedDigits = stack.Reverse();

            MaximumJoltage = 0;
            foreach (var d in selectedDigits)
            {
                MaximumJoltage = MaximumJoltage * 10 + d;
            }
        }
    }
}
