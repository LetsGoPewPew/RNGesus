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

            List<int> results = new List<int>();

            Rng rng = new Rng(10, 3);
            results = rng.GenerateAllResults(results);

            foreach(int i in results)
            {
                Console.WriteLine(i);
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            RenameOutcomesForm renameForm = new RenameOutcomesForm(WeightedNamedOutcome.GetOutcomes(), Decimal.ToInt32(numericUpDownNumberOfOutcomes.Value));
            renameForm.ShowDialog();
            //open form
        }
    }
}
