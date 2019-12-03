using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Uncategorized
    {
        public string GetPercentageXOfY(double x, double y)
        {
            double result = Math.Round((x / y) * 100, 2);

            return result.ToString() + "%";
        }
    }
}
