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
            SimulationRepresentationForm simulationRepresentationForm = 
                new SimulationRepresentationForm(Decimal.ToInt32(numericUpDownTotalWeight.Value), Decimal.ToInt32(numericUpDownNumberOfRounds.Value));
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
