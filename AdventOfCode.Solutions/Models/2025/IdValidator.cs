using System.IO;

namespace AdventOfCode.AdventOfCode.Solutions.Models
{
    public class IdValidator
    {
        private bool IncludeAll { get; set; }

        public IEnumerable<long> FindInvalidIds(string[] ranges, bool includeAll = false)
        {
            IncludeAll = includeAll;
            foreach (var range in ranges)
            {
                var split = range.Split("-");
                var start = long.Parse(split[0]);
                var end = long.Parse(split[1]);
                for (var id = start; id <= end; id++)
                {
                    if (!IsValidId(id))
                    {
                        yield return id;
                    }
                }
            }
        }

        private bool IsValidId(long id)
        {
            var idStr = id.ToString();
            var isOddLength = idStr.Length % 2 != 0;

            if (isOddLength && !IncludeAll)
            {
                return true;
            }

            for (var i = 2; i <= idStr.Length; i++)
            {
                if (idStr.Length % i != 0)
                {
                    continue;
                }

                var parts = SplitIntoParts(idStr, i);
                var isValid = new HashSet<string>(parts).Count != 1;
                if (!isValid)
                {
                    return false;
                }
            }

            return true;
        }

        private List<string> SplitIntoParts(string str, int parts)
        {
            int partSize = str.Length / parts;
            var result = new List<string>(parts);

            for (int i = 0; i < parts; i++)
            {
                int start = i * partSize;
                result.Add(str.Substring(start, partSize));
            }

            return result;
        }
    }
}
