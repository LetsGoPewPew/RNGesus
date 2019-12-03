using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Outcome
    {
        public static int AmountOfOutcomesCreated = 0;
        private int number;
        private int name;

        public int Number { get => number; set => number = value; }
        public int Name { get => name; set => name = value; }

        public Outcome()
        {
            number = ++AmountOfOutcomesCreated;
        }
    }
}
