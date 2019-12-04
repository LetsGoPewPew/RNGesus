using System;
using System.ComponentModel;
using System.Windows.Forms;
using Model;
using BusinessLogic;
namespace view
{
    public partial class RenameOutcomesForm : Form
    {
        public RenameOutcomesForm(int totalWeight)
        { 
            InitializeComponent();
            listBoxOutcomes.DataSource = WeightedNamedOutcome.Outcomes;
            textBoxTotalWeight.Text = "Total weight: " + totalWeight;
            UpdateCurrentUsedWeight();

            WeightedNamedOutcome.Outcomes.ListChanged += new ListChangedEventHandler(Outcomes_ListChanged);
        }

        private void Outcomes_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateCurrentUsedWeight();
        }

        private void buttonAddOutcome_Click(object sender, EventArgs e)
        {
            new AddOutcomeForm().ShowDialog();
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            if(listBoxOutcomes.SelectedItem == null)
            {
                return;
            }
            WeightedNamedOutcome.Outcomes.Remove(listBoxOutcomes.SelectedItem as WeightedNamedOutcome);
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            WeightedNamedOutcome.Outcomes.Clear();
        }

        public void UpdateCurrentUsedWeight()
        {
            //keep up-to-date
            textBoxCurrentUsedWeight.Text = "Current used weight: " + Uncategorized.GetTotalCombinedWeight(WeightedNamedOutcome.Outcomes);
        }

        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
