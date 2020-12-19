namespace AdventOfCode.Solutions.Year2020
{
    public class SurveyUser
    {
        public char[] SurveyElections { get; }

        public SurveyUser(string u)
        {
            SurveyElections = u.ToCharArray();
        }

    }
}