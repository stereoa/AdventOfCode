using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.AdventOfCode.Solutions.Models
{
    public class Dial
    {
        public int CurrentPosition { get; private set; } = 50;
        public int ZeroTriggerCount { get; private set; }

        public void ProcessDirections(string[] directions)
        {
            foreach (var direction in directions)
            {
                if (string.IsNullOrWhiteSpace(direction)) continue;
                var turnDirection = direction[0];
                if (!int.TryParse(direction[1..].Trim(), out int turnAmount))
                {
                    throw new ArgumentException($"Invalid turn amount in direction: {direction}");
                }
                if (turnDirection == 'L')
                {
                    CurrentPosition -= turnAmount;
                }
                else if (turnDirection == 'R')
                {
                    CurrentPosition += turnAmount;
                }
                else
                {
                    throw new ArgumentException($"Invalid turn direction in direction: {direction}");
                }
                while (CurrentPosition < 0)
                {
                    CurrentPosition += 100;
                }
                while (CurrentPosition >= 100)
                {
                    CurrentPosition -= 100;
                }
                if (CurrentPosition == 0)
                {
                    ZeroTriggerCount++;
                }
            }
        }
    }
}
