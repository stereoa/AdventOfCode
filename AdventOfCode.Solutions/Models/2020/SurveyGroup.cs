namespace AdventOfCode.Solutions.Year2020
{
    public class SurveyGroup
    {
        public IEnumerable<SurveyUser> SurveyUsers { get; }
        public int DistinctTotal => SurveyUsers.SelectMany(u => u.SurveyElections)
                                               .Distinct()
                                               .Count();
        public IEnumerable<char> ElectedByAll => SurveyUsers.SelectMany(u => u.SurveyElections)
                                                 .GroupBy(c => c)
                                                 .Where(g => g.Count() == SurveyUsers.Count())
                                                 .Select(g => g.Key);
        public SurveyGroup(string data)
        {
            SurveyUsers = data.SplitByNewline().Select(u => new SurveyUser(u));
        }

    }
}