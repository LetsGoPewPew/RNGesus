using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Model;
namespace view
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if(!IsTotalWeightHigherOrEqualToUsedWeight())
            {
                MessageBox.Show("The total weight must be higher than or equal to the weight used by your outcomes.", "Weight not legal(get a lawyer)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int totalWeight = Decimal.ToInt32(numericUpDownTotalWeight.Value);
            int numberOfRepeats = Decimal.ToInt32(numericUpDownNumberOfRounds.Value);
            int usedWeight = Uncategorized.GetTotalCombinedWeight(WeightedNamedOutcome.Outcomes);

            List<int> results = GetResults(totalWeight, numberOfRepeats);

            CompleteOutcomeSimulation(totalWeight, usedWeight, results);

            SimulationRepresentationForm simulationRepresentationForm =
                new SimulationRepresentationForm(totalWeight, numberOfRepeats, WeightedNamedOutcome.Outcomes, results);
            simulationRepresentationForm.Show();
        }

        private bool IsTotalWeightHigherOrEqualToUsedWeight()
        {
            if(Decimal.ToInt32(numericUpDownTotalWeight.Value) >= Uncategorized.GetTotalCombinedWeight(WeightedNamedOutcome.Outcomes))
            {
                return true;
            }
            return false;
        }

        private static void CompleteOutcomeSimulation(int totalWeight, int usedWeight, List<int> results)
        {
            //the order of these do matter.
            WeightedNamedOutcome.Outcomes = Uncategorized.AddNothingOutcome(WeightedNamedOutcome.Outcomes, totalWeight, usedWeight);
            WeightedNamedOutcome.Outcomes = ResultAndOutcomeMerger.AssignNumberRangeToOutcomes(WeightedNamedOutcome.Outcomes);
            WeightedNamedOutcome.Outcomes = ResultAndOutcomeMerger.AssignResultsToOutcomes(results, WeightedNamedOutcome.Outcomes);
            WeightedNamedOutcome.Outcomes = Uncategorized.SetMultipleChanceToOccur(WeightedNamedOutcome.Outcomes, totalWeight);
        }

        private List<int> GetResults(int totalWeight, int numberOfRepeats)
        {
            Rng rng = new Rng(numberOfRepeats, totalWeight);
            return rng.GenerateAllResults();
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            RenameOutcomesForm renameForm = new RenameOutcomesForm(Decimal.ToInt32(numericUpDownTotalWeight.Value));
            renameForm.ShowDialog();
            //open form
        }
    }
}
