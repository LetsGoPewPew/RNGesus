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
            int totalWeight = Decimal.ToInt32(numericUpDownTotalWeight.Value);
            int numberOfRepeats = Decimal.ToInt32(numericUpDownNumberOfRounds.Value);
            Rng rng = new Rng(numberOfRepeats, totalWeight);
            List<int> results = rng.GenerateAllResults();

            SimulationRepresentationForm simulationRepresentationForm = 
                new SimulationRepresentationForm(totalWeight, numberOfRepeats, WeightedNamedOutcome.Outcomes, results);
            simulationRepresentationForm.Show();
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            RenameOutcomesForm renameForm = new RenameOutcomesForm(Decimal.ToInt32(numericUpDownTotalWeight.Value));
            renameForm.ShowDialog();
            //open form
        }
    }
}
