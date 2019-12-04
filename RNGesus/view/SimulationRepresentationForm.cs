using BusinessLogic;
using Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace view
{
    public partial class SimulationRepresentationForm : Form
    {
        private int totalWeight;
        private int numberOfRepeats;
        private int totalUsedWeight;

        public SimulationRepresentationForm(int totalWeight, int numberOfRepeats, BindingList<WeightedNamedOutcome> outcomes, List<int>results)
        {
            InitializeComponent();
            listViewSimulationResult.View = View.Details;
            FillListView(outcomes);
            
            this.totalWeight = totalWeight;
            this.numberOfRepeats = numberOfRepeats;
            this.totalUsedWeight = Uncategorized.GetTotalCombinedWeight(outcomes);
            InitializeTextValues();
        }

        private void FillListView(BindingList<WeightedNamedOutcome> outcomes)
        {
            foreach(WeightedNamedOutcome outcome in outcomes)
            {
                ListViewItem item = new ListViewItem(outcome.Name);
                item.SubItems.Add("" + outcome.Weight);
                item.SubItems.Add("" + outcome.Occurances);
                item.SubItems.Add(outcome.ChanceToOccur + "%");
                item.SubItems.Add("percent of occurances");

                listViewSimulationResult.Items.Add(item);
            }
        }

        private void InitializeTextValues()
        {
            textBoxNumberOfRepeats.Text = "Number of repeats: " + numberOfRepeats;
            textBoxTotalWeight.Text = "Total weight: " + totalWeight;
        }

        private int GetLeftoverWeight()
        {
            return totalWeight - totalUsedWeight;
        }
    }
}
