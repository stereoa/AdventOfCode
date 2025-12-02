using AdventOfCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class MonsterMessageTests
    {
        const string _input = "0: 4 1 5\n" +
                              "1: 2 3 | 3 2\n" +
                              "2: 4 4 | 5 5\n" +
                              "3: 4 5 | 5 4\n" +
                              "4: \"a\"\n" +
                              "5: \"b\"\n" +
                              "\n" +
                              "ababbb\n" +
                              "bababa\n" +
                              "abbbab\n" +
                              "aaabbb\n" +
                              "aaaabbb\n";

        IEnumerable<MonsterMessageRule> _rules { get; set; }
        IEnumerable<string> _messages { get; set; }

        [TestMethod]
        public void Test_Day19PartOneExample()
        {
            //var data = _input.Split("\n\n");
            //_rules = data[0].SplitByNewline().Select(d => new MonsterMessageRule(d)).OrderBy(d => d.Index).ToList();
            //_messages = data[1].SplitByNewline();

            //var populated = _rules.Where(r => r.CharacterSets.Any());
            //var unpopulatedRules = _rules.Where(r => !r.CharacterSets.Any());

            //while (unpopulatedRules.Any())
            //{
            //    foreach (var unpopulatedRule in unpopulatedRules)
            //    {
            //        foreach (var ruleSet in unpopulatedRule.RuleSets)
            //        {
            //            var rules = populated.Where(r => ruleSet.Any(s => s == r.Index)).ToList();
            //            if (rules.Count() == ruleSet.Distinct().Count())
            //            {

            //                foreach (var rule in ruleSet)
            //                {
            //                    var charSets = rules.First(r => r.Index == rule).CharacterSets;
            //                    foreach (var set in charSets)
            //                    {
            //                        charSet += set;
            //                    }
            //                }
            //                if (!unpopulatedRule.CharacterSets.Contains(charSet))
            //                {
            //                    unpopulatedRule.CharacterSets.Add(charSet);
            //                }
            //            }
            //        }
            //    }

            //    unpopulatedRules = unpopulatedRules.Where(r => r.RuleSets.Any() &&
            //                                                   r.CharacterSets.Count() != r.RuleSets.Count());
            //    populated = _rules.Where(r => !unpopulatedRules.Any(u => u.Index == r.Index));
            //}

            //var firstRule = _rules.First();


            //var matchedMessages = _messages.Where(m => firstRule.CharacterSets.Any(v => v == m));
            //Assert.AreEqual(2, matchedMessages.Count());
        }

        [TestMethod]
        public void Test_DaySevenPartTwoExample()
        {

        }
    }
}
