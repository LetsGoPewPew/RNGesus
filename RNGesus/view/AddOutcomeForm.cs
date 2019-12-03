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
    public partial class AddOutcomeForm : Form
    {
        public AddOutcomeForm()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int weight = Decimal.ToInt32(numericUpDownWeight.Value);

            new WeightedNamedOutcome(name, weight);

            this.Close();
        }
    }
}
