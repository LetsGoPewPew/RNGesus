using ApprovalTests;
using ApprovalTests.Reporters;
using ApprovalTests.Reporters.Windows;
using Model;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.ComponentModel;
using System.Text;

namespace RNGesus.Tests
{
    [UseReporter(typeof(VisualStudioReporter))]
    [TestFixture]
    public class JSONTests
    {
        private BindingList<WeightedNamedOutcome> outcomes = new BindingList<WeightedNamedOutcome>();
        private string json;

        [OneTimeSetUp]
        public void Init()
        {
            outcomes.Add(new WeightedNamedOutcome("Stian1", 1, false));
            outcomes.Add(new WeightedNamedOutcome("Stian2", 2, false));
            outcomes.Add(new WeightedNamedOutcome("Stian3", 3, false));
            outcomes.Add(new WeightedNamedOutcome("Stian4", 4, false));
            outcomes.Add(new WeightedNamedOutcome("Stian5", 5, false));
            outcomes.Add(new WeightedNamedOutcome("Stian6", 6, false));
            outcomes.Add(new WeightedNamedOutcome("Stian7", 7, false));
            outcomes.Add(new WeightedNamedOutcome("Stian8", 8, false));
            outcomes.Add(new WeightedNamedOutcome("Stian9", 9, false));
            outcomes.Add(new WeightedNamedOutcome("Stian10", 10, false));

            json = JsonConvert.SerializeObject(outcomes, Formatting.Indented);
        }
        [Test]
        public void Assert_that_serializing_collection_is_correct()
        {
            Approvals.VerifyJson(json);
        }

        [Test]
        public void Assert_that_deserializing_collection_is_correct()
        {
            BindingList<WeightedNamedOutcome> deserializedJson = JsonConvert.DeserializeObject<BindingList<WeightedNamedOutcome>>(json);

            StringBuilder result = new StringBuilder();
            foreach (WeightedNamedOutcome outcome in outcomes)
            {
                result.AppendLine("Name:" + outcome.Name + " Weight: " + outcome.Weight + " Occurances: " + outcome.Occurances + " Chance to occur:" + outcome.ChanceToOccur);
            }

            Approvals.Verify(result);
        }
    }   
}
