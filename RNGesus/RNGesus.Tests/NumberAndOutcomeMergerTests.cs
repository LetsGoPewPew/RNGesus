using Model;
using NUnit.Framework;
using BusinessLogic;
using ApprovalTests;
using ApprovalTests.Reporters;
using System.Text;
using System.Collections.Generic;
using ApprovalTests.Reporters.Windows;
using System.ComponentModel;
using System;
using System.Diagnostics;

namespace RNGesus.Tests
{
    [UseReporter(typeof(VisualStudioReporter))]
    [TestFixture]
    class NumberAndOutcomeMergerTests
    {
        private BindingList<WeightedNamedOutcome> outcomes = new BindingList<WeightedNamedOutcome>();
        private List<int> results = new List<int>();
        private int totalWeight = 110;

        [OneTimeSetUp]
        public void Init()
        {
            outcomes.Add(new WeightedNamedOutcome("Stian1", 1, true));
            outcomes.Add(new WeightedNamedOutcome("Stian2", 2, true));
            outcomes.Add(new WeightedNamedOutcome("Stian3", 3, true));
            outcomes.Add(new WeightedNamedOutcome("Stian4", 4, true));
            outcomes.Add(new WeightedNamedOutcome("Stian5", 5, true));
            outcomes.Add(new WeightedNamedOutcome("Stian6", 6, true));
            outcomes.Add(new WeightedNamedOutcome("Stian7", 7, true));
            outcomes.Add(new WeightedNamedOutcome("Stian8", 8, true));
            outcomes.Add(new WeightedNamedOutcome("Stian9", 9, true));
            outcomes.Add(new WeightedNamedOutcome("Stian10", 10, true));

            results.Add(1);
            results.Add(1);

            results.Add(2);
            results.Add(3);

            results.Add(4);
            results.Add(6);

            results.Add(7);
            results.Add(10);

            results.Add(11);
            results.Add(15);

            results.Add(16);
            results.Add(21);

            results.Add(22);
            results.Add(28);

            results.Add(29);
            results.Add(36);

            results.Add(37);
            results.Add(45);

            results.Add(46);
            results.Add(55);

            results.Add(56);
            results.Add(110);

            outcomes = Uncategorized.AddNothingOutcome(outcomes, totalWeight, Uncategorized.GetTotalCombinedWeight(outcomes));
            outcomes = ResultAndOutcomeMerger.AssignNumberRangeToOutcomes(outcomes);

        }

        [Test]
        public void Assert_that_range_values_are_correct()
        {
            StringBuilder result = new StringBuilder();
            foreach(WeightedNamedOutcome outcome in outcomes)
            {
                result.AppendLine(outcome.GetRange().ToString() + "  ---  " + outcome.Name);
            }
            Approvals.Verify(result);
        }

        [Test]
        public void Assert_that_occurances_are_correct()
        {
            BindingList<WeightedNamedOutcome> outcomeResults = ResultAndOutcomeMerger.AssignResultsToOutcomes(results, outcomes);

            int[] expected = new int[outcomeResults.Count];
            int[] result = new int[outcomeResults.Count];

            for (int i = 0; i < expected.Length; i++)
            {
                expected[i] = 2;
            }

            for(int i = 0; i < result.Length; i++)
            {
               result[i] = outcomeResults[i].Occurances;
               Console.WriteLine(outcomeResults[i].ToString() + " " + outcomeResults[i].Occurances);
            }

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
