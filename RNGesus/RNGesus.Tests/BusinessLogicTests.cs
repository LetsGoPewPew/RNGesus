using BusinessLogic;
using NUnit.Framework;
using System.Collections.Generic;

namespace RNGesus.Tests
{
    public class Tests
    {
        private Rng rng1;
        private int outcomes = 12;
        private int repeats = 100;
        private List<int> results = new List<int>();

        [SetUp]
        public void Setup()
        {
            rng1 = new Rng(repeats, outcomes);
        }

        [Test]
        public void Assert_correct_number_of_repeats()
        {
            rng1.GenerateAllResults(results);
            Assert.AreEqual(repeats, results.Count);
        }
    }
}