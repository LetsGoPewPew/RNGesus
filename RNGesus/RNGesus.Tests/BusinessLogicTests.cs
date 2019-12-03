using BusinessLogic;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace RNGesus.Tests
{
    [TestFixture]
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
            rng1.GenerateAllResults(results);
        }

        [Test]
        public void Assert_correct_number_of_repeats()
        {
            Assert.AreEqual(repeats, results.Count);
        }

        [Test]
        public void Assert_correct_outcomes_value_range()
        {
            bool result = results.TrueForAll(IsCorrectOutcomeValueRange);
            Assert.IsTrue(result);
        }

        private bool IsCorrectOutcomeValueRange(int i)
        {
            if(i > outcomes || i < 1)
            {
                return false;
            }
            return true;
        }
    }
}