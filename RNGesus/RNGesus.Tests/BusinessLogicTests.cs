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
        private readonly int outcomes = 12;
        private readonly int repeats = 100;
        private List<int> results = new List<int>();

        [SetUp]
        public void Setup()
        {
            rng1 = new Rng(repeats, outcomes);
            results = rng1.GenerateAllResults();
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

        [Test]
        public void Assert_that_percentage_is_returned_without_decimals()
        {
            double result = Uncategorized.GetPercentageXOfY(50, 100);
            double expected = 50;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Assert_that_percentage_has_two_decimals_when_needed()
        {
            double result = Uncategorized.GetPercentageXOfY(1111, 10000);
            double expected = 11.11;
            Assert.That(result, Is.EqualTo(expected));
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