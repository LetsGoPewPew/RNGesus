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
            this.textBoxWeightUsed = new System.Windows.Forms.TextBox();
            this.textBoxNothingWeight = new System.Windows.Forms.TextBox();
            this.textBoxWeightUsedPercent = new System.Windows.Forms.TextBox();
            this.textBoxNothingWeightPercent = new System.Windows.Forms.TextBox();
            this.textBoxRounds = new System.Windows.Forms.TextBox();
            this.listViewSimulationResults = new System.Windows.Forms.ListView();
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
            // textBoxWeightUsed
            // 
            this.textBoxWeightUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeightUsed.Location = new System.Drawing.Point(395, 12);
            this.textBoxWeightUsed.Name = "textBoxWeightUsed";
            this.textBoxWeightUsed.ReadOnly = true;
            this.textBoxWeightUsed.Size = new System.Drawing.Size(317, 26);
            this.textBoxWeightUsed.TabIndex = 2;
            this.textBoxWeightUsed.Text = "Weight used: ";
            // 
            // textBoxNothingWeight
            // 
            this.textBoxNothingWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNothingWeight.Location = new System.Drawing.Point(395, 44);
            this.textBoxNothingWeight.Name = "textBoxNothingWeight";
            this.textBoxNothingWeight.ReadOnly = true;
            this.textBoxNothingWeight.Size = new System.Drawing.Size(317, 26);
            this.textBoxNothingWeight.TabIndex = 3;
            this.textBoxNothingWeight.Text = "Weight leftover for \"nothing\" outcome: ";
            // 
            // textBoxWeightUsedPercent
            // 
            this.textBoxWeightUsedPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeightUsedPercent.Location = new System.Drawing.Point(718, 12);
            this.textBoxWeightUsedPercent.Name = "textBoxWeightUsedPercent";
            this.textBoxWeightUsedPercent.Size = new System.Drawing.Size(63, 26);
            this.textBoxWeightUsedPercent.TabIndex = 4;
            this.textBoxWeightUsedPercent.Text = "00.00%";
            // 
            // textBoxNothingWeightPercent
            // 
            this.textBoxNothingWeightPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNothingWeightPercent.Location = new System.Drawing.Point(718, 44);
            this.textBoxNothingWeightPercent.Name = "textBoxNothingWeightPercent";
            this.textBoxNothingWeightPercent.Size = new System.Drawing.Size(63, 26);
            this.textBoxNothingWeightPercent.TabIndex = 5;
            this.textBoxNothingWeightPercent.Text = "00.00%";
            // 
            // textBoxRounds
            // 
            this.textBoxRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRounds.Location = new System.Drawing.Point(12, 44);
            this.textBoxRounds.Name = "textBoxRounds";
            this.textBoxRounds.Size = new System.Drawing.Size(298, 26);
            this.textBoxRounds.TabIndex = 6;
            this.textBoxRounds.Text = "Total rounds:";
            // 
            // listViewSimulationResults
            // 
            this.listViewSimulationResults.HideSelection = false;
            this.listViewSimulationResults.Location = new System.Drawing.Point(13, 77);
            this.listViewSimulationResults.Name = "listViewSimulationResults";
            this.listViewSimulationResults.Size = new System.Drawing.Size(775, 361);
            this.listViewSimulationResults.TabIndex = 7;
            this.listViewSimulationResults.UseCompatibleStateImageBehavior = false;
            // 
            // SimulationRepresentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewSimulationResults);
            this.Controls.Add(this.textBoxRounds);
            this.Controls.Add(this.textBoxNothingWeightPercent);
            this.Controls.Add(this.textBoxWeightUsedPercent);
            this.Controls.Add(this.textBoxNothingWeight);
            this.Controls.Add(this.textBoxWeightUsed);
            this.Controls.Add(this.textBoxTotalWeight);
            this.Name = "SimulationRepresentationForm";
            this.Text = "SimulationRepresentationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTotalWeight;
        private System.Windows.Forms.TextBox textBoxWeightUsed;
        private System.Windows.Forms.TextBox textBoxNothingWeight;
        private System.Windows.Forms.TextBox textBoxWeightUsedPercent;
        private System.Windows.Forms.TextBox textBoxNothingWeightPercent;
        private System.Windows.Forms.TextBox textBoxRounds;
        private System.Windows.Forms.ListView listViewSimulationResults;
    }
}