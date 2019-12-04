using Model;
using System.Collections.Generic;
using System.ComponentModel;

namespace BusinessLogic
{
    public static class ResultAndOutcomeMerger
    {
        public static BindingList<WeightedNamedOutcome> AssignNumberRangeToOutcomes(BindingList<WeightedNamedOutcome> outcomes)
        {
            int currentNumber = 1;
            foreach(WeightedNamedOutcome outcome in outcomes)
            {
                int weight = outcome.Weight;
                int startRange = currentNumber;
                int stopRange = (currentNumber + weight) -1;

                outcome.SetRange(startRange, stopRange);

                currentNumber += weight;
            }
            return outcomes;
        }

        public static BindingList<WeightedNamedOutcome> AssignResultsToOutcomes(List<int> results, BindingList<WeightedNamedOutcome> outcomes)
        {
            //TODO: Find out how to assign results to outcomes in a optimal way.
            results.Sort();
            foreach(WeightedNamedOutcome outcome in outcomes)
            {
                foreach(int result in results)
                {
                    if( (outcome.GetRange().stopRange < result) || (outcome.GetRange().startRange > result) )
                    {
                        continue;
                    }
                    outcome.Occurances++;
                }
            }
            return outcomes;
        }
    }
}
