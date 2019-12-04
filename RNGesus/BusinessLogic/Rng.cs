using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Rng
    {
        private int numberOfRepeats;
        private int totalWeight;

        public int NumberOfRepeats { get => numberOfRepeats; set => numberOfRepeats = value; }
        public int TotalWeight { get => totalWeight; set => totalWeight = value; }

        public Random rng = new Random();

        public Rng(int numberOfRepeats, int totalWeight)
        {
            this.totalWeight = totalWeight;
            this.numberOfRepeats = numberOfRepeats;
        }

        public List<int> GenerateAllResults()
        {
            List<int> results = new List<int>();
            for(int i = 0; i < numberOfRepeats; i++)
            {
                results.Add(GenerateResult());
            }
            return results;
        }

        private int GenerateResult()
        {
            return rng.Next(1, totalWeight + 1);
        }
    }
}
