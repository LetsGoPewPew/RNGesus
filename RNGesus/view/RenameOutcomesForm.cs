﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
namespace view
{
    public partial class RenameOutcomesForm : Form
    {
        public RenameOutcomesForm(List<WeightedNamedOutcome> outcomes, int totalWeight)
        { 
            InitializeComponent();
            listBoxOutcomes.DataSource = outcomes;

            //once
            textBoxTotalWeight.Text = "Total weight: " + totalWeight;

            //keep up-to-date
            textBoxCurrentUsedWeight.Text = "Current used weight: " + WeightedNamedOutcome.GetTotalCombinedWeight();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
