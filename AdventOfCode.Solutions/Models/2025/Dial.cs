namespace AdventOfCode.AdventOfCode.Solutions.Models
{
    public class Dial
    {
        public int CurrentPosition { get; private set; } = 50;
        public int ZeroStopCount { get; private set; }
        public int ZeroPassCount { get; private set; }
        public int ZeroTotalCount => ZeroStopCount + ZeroPassCount;

        public int PreviousPosition { get; private set; }

        public void ProcessDirections(string[] directions)
        {
            foreach (var direction in directions)
            {
                if (string.IsNullOrWhiteSpace(direction)) continue;

                char turnDirection = direction[0];
                int amount = int.Parse(direction[1..]);

                int delta = turnDirection == 'L' ? -1 : 1;

                for (int i = 0; i < amount; i++)
                {
                    CurrentPosition += delta;

                    if (CurrentPosition < 0)
                        CurrentPosition += 100;
                    else if (CurrentPosition >= 100)
                        CurrentPosition -= 100;

                    if (CurrentPosition == 0)
                        ZeroPassCount++;
                }

                if (CurrentPosition == 0)
                    ZeroStopCount++;
            }
        }
    }
}
