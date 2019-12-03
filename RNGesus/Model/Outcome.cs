using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WeightedNamedOutcome
    {

        public static List<WeightedNamedOutcome> Outcomes = new List<WeightedNamedOutcome>();
        public static List<WeightedNamedOutcome> GetOutcomes()
        {
            return Outcomes;
        }

        private String name;
        private int weight;

        public String Name { get; set; }
        public int Weight { get => weight; set => weight = value; }

        public WeightedNamedOutcome(String name, int weight = 1)
        {
            this.name = name;
            this.Weight = weight;
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
