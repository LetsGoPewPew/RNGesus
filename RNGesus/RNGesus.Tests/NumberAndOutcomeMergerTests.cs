using Model;
using NUnit.Framework;
using BusinessLogic;
using ApprovalTests;
using ApprovalTests.Reporters;
using System.Text;
using System.Collections.Generic;
using ApprovalTests.Reporters.Windows;

namespace RNGesus.Tests
{
    [UseReporter(typeof(VisualStudioReporter))]
    [TestFixture]
    class NumberAndOutcomeMergerTests
    {
        private List<WeightedNamedOutcome> outcomes = new List<WeightedNamedOutcome>();
        private NumberAndOutcomeMerger numberAndOutcomeMerger;

        [OneTimeSetUp]
        public void init()
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

            numberAndOutcomeMerger = new NumberAndOutcomeMerger(new List<int>(), outcomes);
        }
        
        [Test]
        public void Assert_that_range_values_are_correct()
        {
            StringBuilder result = new StringBuilder();
            
            foreach(WeightedNamedOutcome outcome in numberAndOutcomeMerger.GetOutcomes())
            {
                result.AppendLine(outcome.GetRange().ToString() + "  ---  " + outcome.Name);
            }

            Approvals.Verify(result);
        }
    }
}
