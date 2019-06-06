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
        private int numberOfOutcomes;

        public int NumberOfRepeats { get => numberOfRepeats; set => numberOfRepeats = value; }
        public int NumberOfOutcomes { get => numberOfOutcomes; set => numberOfOutcomes = value; }

        public Random rng = new Random();

        public Rng(int numberOfRepeats, int numberOfOutcomes)
        {
            this.numberOfOutcomes = numberOfOutcomes;
            this.numberOfRepeats = numberOfRepeats;
        }

        public List<int> GenerateAllResults(List<int> results)
        {
            for(int i = 0; i < numberOfRepeats; i++)
            {
                results.Add(GenerateResult());
            }
            return results;
        }

        private int GenerateResult()
        {
            return rng.Next(1, numberOfOutcomes);
        }
    }
}
