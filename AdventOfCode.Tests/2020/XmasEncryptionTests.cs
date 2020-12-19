using AdventOfCode.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class XmasEncryptionTests
    {
        const string _input = "35\n" +
                              "20\n" +
                              "15\n" +
                              "25\n" +
                              "47\n" +
                              "40\n" +
                              "62\n" +
                              "55\n" +
                              "65\n" +
                              "95\n" +
                              "102\n" +
                              "117\n" +
                              "150\n" +
                              "182\n" +
                              "127\n" +
                              "219\n" +
                              "299\n" +
                              "277\n" +
                              "309\n" +
                              "576";
        [TestMethod]
        public void Test_DayNinePartOneExample()
        {
            var encryption = new XmasEncryption(_input, 5);
            Assert.AreEqual(127, encryption.Weakpoint);
        }

        [TestMethod]
        public void Test_DayNinePartTwoExample()
        {
            var input = "35\n" +
                        "20\n" +
                        "15\n" +
                        "25\n" +
                        "47\n" +
                        "40\n" +
                        "62\n" +
                        "55\n" +
                        "65\n" +
                        "95\n" +
                        "102\n" +
                        "117\n" +
                        "150\n" +
                        "182\n" +
                        "127\n" +
                        "219\n" +
                        "299\n" +
                        "277\n" +
                        "309\n" +
                        "576";
            var encryption = new XmasEncryption(input, 5);
            Assert.AreEqual(62, encryption.Weakness);
        }
    }
}
