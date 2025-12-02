namespace AdventOfCode.Models
{
    public class SonarSweep
    {
        public List<int> Measurements;

        public SonarSweep(List<int> measurements)
        {
            Measurements = measurements;
        }

        public int GetIncreaseCount(List<int> input)
        {
            var count = 0;
            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] < input[i + 1])
                {
                    count++;
                }
            }
            return count;
        }

        public List<int> Windows
        {
            get
            {
                var windows = new List<int>();
                for (int i = 0; i < Measurements.Count - 2; i++)
                {
                    windows.Add(Measurements[i] + Measurements[i + 1] + Measurements[i + 2]);
                }
                return windows;
            }
        }
    }
}
