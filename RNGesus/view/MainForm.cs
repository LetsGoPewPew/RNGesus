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
    }
}
