using BusinessLogic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class SimulationRepresentationForm : Form
    {
        private int totalWeight;
        private int numberOfRounds;
        private int totalUsedWeight;

        public SimulationRepresentationForm(int totalWeight, int numberOfRounds, BindingList<WeightedNamedOutcome> outcomes, List<int>results)
        {
            InitializeComponent();

            this.totalWeight = totalWeight;
            this.numberOfRounds = numberOfRounds;
            this.totalUsedWeight = Uncategorized.GetTotalCombinedWeight(outcomes);
            InitializeTextValues();
        }

        private void InitializeTextValues()
        {
            textBoxTotalWeight.Text = "Total weight: " + totalWeight;
            textBoxWeightUsed.Text = "Weight used: " + totalUsedWeight;
            textBoxNothingWeight.Text = "Weight leftover for 'nothing' outcome: " + GetLeftoverWeight();
            textBoxWeightUsedPercent.Text = Uncategorized.GetPercentageXOfY(totalUsedWeight, totalWeight);
            textBoxNothingWeightPercent.Text = Uncategorized.GetPercentageXOfY(GetLeftoverWeight(), totalWeight);
        }

        private int GetLeftoverWeight()
        {
            return totalWeight - totalUsedWeight;
        }
    }
}
