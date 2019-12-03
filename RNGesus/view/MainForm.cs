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
        private List<Outcome> outcomes = new List<Outcome>();

        public List<Outcome> Outcomes { get => outcomes; set => outcomes = value; }

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
            if(Outcomes.Count < 2)
            {
                for(int i = 0; i == (int)numericUpDownNumberOfOutcomes.Value; i++)
                {
                    Outcomes.Add(new Outcome());
                }
            }

            RenameOutcomesForm renameForm = new RenameOutcomesForm(Outcomes);
            renameForm.ShowDialog();
            //open form
        }
    }
}
