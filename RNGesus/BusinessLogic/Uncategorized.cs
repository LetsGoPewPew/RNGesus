using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class Uncategorized
    {
        public static string GetPercentageXOfY(double x, double y)
        {
            double result = Math.Round((x / y) * 100, 2);

            return result.ToString() + "%";
        }

        public static BindingList<WeightedNamedOutcome> AddNothingOutcome(BindingList<WeightedNamedOutcome> outcomes, int totalWeight, int usedWeight)
        {
            int nothingWeight = totalWeight - usedWeight;
            if(nothingWeight == 0)
            {
                return outcomes;
            }
            WeightedNamedOutcome nothing = new WeightedNamedOutcome("Nothing", nothingWeight);
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
