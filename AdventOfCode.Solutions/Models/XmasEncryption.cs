namespace AdventOfCode.Models
{
    public class XmasEncryption
    {
        public int[] Data;
        public int PreambleLength { get; }

        public XmasEncryption(string input, int preambleLength)
        {
            Data = input.ToIntArray("\n");
            PreambleLength = preambleLength;
        }

        public int Weakpoint
        {
            get
            {
                for (var i = PreambleLength; i < Data.Length; i++)
                {
                    var targetFound = false;
                    var currentTarget = Data[i];
                    for (var j = i - PreambleLength; j < i; j++)
                    {
                        for (var k = j + 1; k < i; k++)
                        {
                            if (Data[j] + Data[k] == currentTarget)
                            {
                                targetFound = true;
                            }
                            if (targetFound)
                            {
                                break;
                            }
                        }
                        if (targetFound)
                        {
                            break;
                        }
                    }

                    if (!targetFound)
                    {
                        return currentTarget;
                    }
                }
                return 0;
            }

        }

        public int Weakness
        {
            get
            {
                var weakpoint = Weakpoint;
                var attackRange = Data.Where(d => d < weakpoint).ToArray();

                for (var i = 0; i < attackRange.Length - 2; i++)
                {
                    var sum = attackRange[i];
                    for (var j = i + 1; j < attackRange.Length - 1; j++)
                    {
                        sum += attackRange[j];
                        if (sum < weakpoint)
                        {
                            continue;
                        }
                        if (sum == weakpoint)
                        {
                            var range = attackRange[i..j];

                            return range.Min() + range.Max();
                        }
                        if (sum > weakpoint)
                        {
                            break;
                        }
                    }
                }
                return 0;
            }
        }

    }
}
