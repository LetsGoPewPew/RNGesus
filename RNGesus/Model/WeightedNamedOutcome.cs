using System;
using System.ComponentModel;

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
        private int occurances;
        private double chanceToOccur;

        public String Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Occurances { get => occurances; set => occurances = value; }
        public double ChanceToOccur { get => chanceToOccur; set => chanceToOccur = value; }

        public WeightedNamedOutcome(String name, int weight = 1, bool autoAddToList = true)
        {
            this.name = name;
            this.Weight = weight;
            this.Id = ++outcomeCounter;
            if(autoAddToList)
            {
                Outcomes.Add(this);
            }
        }

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

        public override string ToString()
        {
            return name + ", weight: " + weight;
        }
    }
}
