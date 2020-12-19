using AdventOfCode.Solutions;
using System.Collections.Generic;

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
                for (var i = PreambleLength; i < Data.Length - PreambleLength; i++)
                {
                    var targetFound = false;
                    var currentTarget = Data[i];
                    for (var j = i - PreambleLength; j < Data.Length - PreambleLength; j++)
                    {
                        for (var k = j + 1; k < j + PreambleLength; k++)
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
                            continue;
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
    }
}
