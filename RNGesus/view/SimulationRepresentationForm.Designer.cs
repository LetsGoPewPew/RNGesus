namespace view
{
    partial class SimulationRepresentationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTotalWeight = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfRepeats = new System.Windows.Forms.TextBox();
            this.listViewSimulationResult = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.occurances = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chanceToOccur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBoxTotalWeight
            // 
            this.textBoxTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalWeight.Location = new System.Drawing.Point(12, 12);
            this.textBoxTotalWeight.Name = "textBoxTotalWeight";
            this.textBoxTotalWeight.ReadOnly = true;
            this.textBoxTotalWeight.Size = new System.Drawing.Size(298, 26);
            this.textBoxTotalWeight.TabIndex = 1;
            this.textBoxTotalWeight.Text = "Total weight: ";
            // 
            // textBoxNumberOfRepeats
            // 
            this.textBoxNumberOfRepeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfRepeats.Location = new System.Drawing.Point(12, 44);
            this.textBoxNumberOfRepeats.Name = "textBoxNumberOfRepeats";
            this.textBoxNumberOfRepeats.Size = new System.Drawing.Size(298, 26);
            this.textBoxNumberOfRepeats.TabIndex = 6;
            this.textBoxNumberOfRepeats.Text = "Total repeats:";
            // 
            // listViewSimulationResult
            // 
            this.listViewSimulationResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.weight,
            this.occurances,
            this.chanceToOccur});
            this.listViewSimulationResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSimulationResult.HideSelection = false;
            this.listViewSimulationResult.Location = new System.Drawing.Point(12, 76);
            this.listViewSimulationResult.MultiSelect = false;
            this.listViewSimulationResult.Name = "listViewSimulationResult";
            this.listViewSimulationResult.Size = new System.Drawing.Size(776, 362);
            this.listViewSimulationResult.TabIndex = 7;
            this.listViewSimulationResult.UseCompatibleStateImageBehavior = false;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 300;
            // 
            // weight
            // 
            this.weight.Text = "Weight";
            this.weight.Width = 100;
            // 
            // occurances
            // 
            this.occurances.Text = "Occurances";
            this.occurances.Width = 100;
            // 
            // chanceToOccur
            // 
            this.chanceToOccur.Text = "Chance to occur per repeat";
            this.chanceToOccur.Width = 300;
            // 
            // SimulationRepresentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewSimulationResult);
            this.Controls.Add(this.textBoxNumberOfRepeats);
            this.Controls.Add(this.textBoxTotalWeight);
            this.Name = "SimulationRepresentationForm";
            this.Text = "SimulationRepresentationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTotalWeight;
        private System.Windows.Forms.TextBox textBoxNumberOfRepeats;
        private System.Windows.Forms.ListView listViewSimulationResult;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader weight;
        private System.Windows.Forms.ColumnHeader occurances;
        private System.Windows.Forms.ColumnHeader chanceToOccur;
    }
}