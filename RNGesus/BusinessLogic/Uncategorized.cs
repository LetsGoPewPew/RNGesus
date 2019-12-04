using Model;
using System;
using System.ComponentModel;

namespace BusinessLogic
{
    public static class Uncategorized
    {
        public static double GetPercentageXOfY(double x, double y)
        {
            double result = Math.Round((x / y) * 100, 2);
            return result;
        }

        public static double CalculateChanceToOccur(WeightedNamedOutcome outcome, int totalWeight)
        {
            return GetPercentageXOfY(outcome.Weight, totalWeight);
        }

        public static BindingList<WeightedNamedOutcome> SetMultipleChanceToOccur(BindingList<WeightedNamedOutcome> outcomes, int totalWeight)
        {
            foreach(WeightedNamedOutcome outcome in outcomes)
            {
                outcome.ChanceToOccur = CalculateChanceToOccur(outcome, totalWeight);
            }
            return outcomes;
        }

        public static void ResetAllOccurances(BindingList<WeightedNamedOutcome> outcomes)
        {
            foreach(WeightedNamedOutcome outcome in outcomes)
            {
                ResetOccurance(outcome);
            }
        }

        private static void ResetOccurance(WeightedNamedOutcome outcome)
        {
            outcome.Occurances = 0;
        }

        public static BindingList<WeightedNamedOutcome> AddNothingOutcome(BindingList<WeightedNamedOutcome> outcomes, int totalWeight, int usedWeight)
        {
            int nothingWeight = totalWeight - usedWeight;
            if(nothingWeight == 0)
            {
                return outcomes;
            }
            WeightedNamedOutcome nothing = new WeightedNamedOutcome("Nothing", nothingWeight, false);
            outcomes.Add(nothing);
            return outcomes;
        }

        public static int GetTotalCombinedWeight(BindingList<WeightedNamedOutcome> outcomes)
        {
            int total = 0;
            foreach (WeightedNamedOutcome i in outcomes)
            {
                total += i.Weight;
            }
            return total;
        }
    }
}
