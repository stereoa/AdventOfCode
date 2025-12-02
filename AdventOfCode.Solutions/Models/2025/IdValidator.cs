namespace AdventOfCode.AdventOfCode.Solutions.Models
{
    public class IdValidator
    {
        public IEnumerable<long> FindInvalidIds(string[] ranges)
        {
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

            if (isOddLength)
            {
                return true;
            }

            var leftHalf = idStr.Substring(0, idStr.Length / 2);
            var rightHalf = idStr.Substring(idStr.Length / 2);

            if (!leftHalf.Equals(rightHalf))
            {
                return true;
            }
         
            return false;
        }
    }
}
