namespace AdventOfCode.Models
{
    public class MonsterMessageRule
    {
        public IEnumerable<IEnumerable<int>> RuleSets { get; }
        public int Index { get; }
        public List<string> CharacterSets = new List<string>();

        public MonsterMessageRule(string data)
        {
            var description = data.Split(": ");
            Index = Convert.ToInt32(description[0]);

            var definition = description[1];

            if (definition.Contains("\""))
            {
                CharacterSets.Add(definition.Replace("\"", ""));
            }
            else
            {
                RuleSets = definition.Split(" | ").Select(r => r.Split(" ").Select(i => Convert.ToInt32(i)));
            }
        }
    }
}