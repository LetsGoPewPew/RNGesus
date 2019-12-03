using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WeightedNamedOutcome
    {
        private String name;
        private int weight;

        public String Name { get; set; }
        public int Weight { get => weight; set => weight = value; }

        public WeightedNamedOutcome(String name, int weight = 1)
        {
            this.name = name;
            this.Weight = weight;
        }
    }
}
