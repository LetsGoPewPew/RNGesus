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
        private Uncategorized uncategorized = new Uncategorized();

        public SimulationRepresentationForm(int totalWeight, int numberOfRounds)
        {
            InitializeComponent();

            this.totalWeight = totalWeight;
            this.numberOfRounds = numberOfRounds;
            this.totalUsedWeight = WeightedNamedOutcome.GetTotalCombinedWeight();
            InitializeTextValues();
        }

        private void InitializeTextValues()
        {
            textBoxTotalWeight.Text = "Total weight: " + totalWeight;
            textBoxWeightUsed.Text = "Weight used: " + totalUsedWeight;
            textBoxNothingWeight.Text = "Weight leftover for 'nothing' outcome: " + GetLeftoverWeight();
            textBoxWeightUsedPercent.Text = uncategorized.GetPercentageXOfY(totalUsedWeight, totalWeight);
            textBoxNothingWeightPercent.Text = uncategorized.GetPercentageXOfY(GetLeftoverWeight(), totalWeight);
        }

        private int GetLeftoverWeight()
        {
            return totalWeight - totalUsedWeight;
        }

        private void doStuff()
        {
            foreach(WeightedNamedOutcome outcome in WeightedNamedOutcome.Outcomes)
            {
                
            }
        }
    }
}
