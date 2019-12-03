using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class NumberAndOutcomeMerger
    {
        private List<WeightedNamedOutcome> outcomes;
        private List<int> results;

        public NumberAndOutcomeMerger(List<int> results, List<WeightedNamedOutcome> outcomes)
        {
            this.outcomes = outcomes;
            this.results = results;

            AssignNumberRangeToOutcomes();
        }

        private void AssignNumberRangeToOutcomes()
        {
            int currentNumber = 1;
            foreach(WeightedNamedOutcome outcome in outcomes)
            {
                int weight = outcome.Weight;
                int startRange = currentNumber;
                int stopRange = currentNumber + weight;

                outcome.SetRange(startRange, stopRange);

                currentNumber += weight;
            }
        }

        public List<WeightedNamedOutcome> GetOutcomes()
        {
            return outcomes;
        }

        private void AssignResultsToOutcomes()
        {
            //TODO: Find out how to assign results to outcomes in a optimal way.
        }

    }
}
