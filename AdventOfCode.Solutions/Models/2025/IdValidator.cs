using System.IO;

namespace AdventOfCode.AdventOfCode.Solutions.Models
{
    public class IdValidator
    {
        public IEnumerable<long> FindInvalidIds(string[] ranges, bool includeAll = false)
        {
            foreach (var range in ranges)
            {
                var parts = range.Split('-');
                var start = long.Parse(parts[0]);
                var end = long.Parse(parts[1]);

                for (long id = start; id <= end; id++)
                {
                    if (IsRepeatedSequence(id, includeAll))
                    {
                        yield return id;
                    }
                }
            }
        }

        private bool IsRepeatedSequence(long number, bool includeAll = false)
        {
            var s = number.ToString();
            var len = s.Length;

            for (var chunkLen = 1; chunkLen <= len / 2; chunkLen++)
            {
                if (len % chunkLen != 0)
                {
                    continue;
                }

                var repeatCount = len / chunkLen;
                if (!includeAll && repeatCount != 2)
                {
                    continue;
                }

                var chunk = s.Substring(0, chunkLen);
                var valid = true;

                for (int i = 1; i < repeatCount; i++)
                {
                    if (s.Substring(i * chunkLen, chunkLen) != chunk)
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
