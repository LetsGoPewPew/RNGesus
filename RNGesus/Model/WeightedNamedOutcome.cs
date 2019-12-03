using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WeightedNamedOutcome
    {

        public static BindingList<WeightedNamedOutcome> Outcomes = new BindingList<WeightedNamedOutcome>();
        public static int outcomeCounter = 0;
        private readonly int Id;

        private Range range;

        private String name;
        private int weight;

        public String Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }

        public void SetRange(int startRange, int stopRange)
        {
            if(range == null)
            {
                range = new Range(startRange, stopRange);
            }
            else
            {
                range.startRange = startRange;
                range.stopRange = stopRange;
            }
            
        }

        public Range GetRange()
        {
            return range;
        }

        public WeightedNamedOutcome(String name, int weight = 1, bool testing = false)
        {
            this.name = name;
            this.Weight = weight;
            this.Id = ++outcomeCounter;

            Outcomes.Add(this);
        }
        
        public static int GetTotalCombinedWeight()
        {
            int total = 0;
            foreach (WeightedNamedOutcome i in Outcomes)
            {
                total += i.Weight;
            }
            return total;
        }

        public override string ToString()
        {
            return name + ", weight: " + weight;
        }
    }
}
