namespace view
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelNumberOfOutcomes = new System.Windows.Forms.Label();
            this.labelNumberOfRepeats = new System.Windows.Forms.Label();
            this.labelNameEachOutcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfOutcomes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumberOfRounds = new System.Windows.Forms.NumericUpDown();
            this.buttonRename = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfOutcomes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumberOfOutcomes
            // 
            this.labelNumberOfOutcomes.AutoSize = true;
            this.labelNumberOfOutcomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfOutcomes.Location = new System.Drawing.Point(12, 62);
            this.labelNumberOfOutcomes.Name = "labelNumberOfOutcomes";
            this.labelNumberOfOutcomes.Size = new System.Drawing.Size(432, 25);
            this.labelNumberOfOutcomes.TabIndex = 0;
            this.labelNumberOfOutcomes.Text = "How many possible outcomes(total weight)?";
            // 
            // labelNumberOfRepeats
            // 
            this.labelNumberOfRepeats.AutoSize = true;
            this.labelNumberOfRepeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfRepeats.Location = new System.Drawing.Point(12, 120);
            this.labelNumberOfRepeats.Name = "labelNumberOfRepeats";
            this.labelNumberOfRepeats.Size = new System.Drawing.Size(306, 25);
            this.labelNumberOfRepeats.TabIndex = 1;
            this.labelNumberOfRepeats.Text = "How many rounds to simulate?";
            // 
            // labelNameEachOutcome
            // 
            this.labelNameEachOutcome.AutoSize = true;
            this.labelNameEachOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameEachOutcome.Location = new System.Drawing.Point(12, 179);
            this.labelNameEachOutcome.Name = "labelNameEachOutcome";
            this.labelNameEachOutcome.Size = new System.Drawing.Size(499, 25);
            this.labelNameEachOutcome.TabIndex = 2;
            this.labelNameEachOutcome.Text = "If you would like to name each outcome, click here:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "-if you don\'t, the outcome names will just be numbers";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(17, 260);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(111, 42);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Generate!";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(727, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fill out the values and click generate to get your result:";
            // 
            // numericUpDownNumberOfOutcomes
            // 
            this.numericUpDownNumberOfOutcomes.Location = new System.Drawing.Point(450, 67);
            this.numericUpDownNumberOfOutcomes.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownNumberOfOutcomes.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNumberOfOutcomes.Name = "numericUpDownNumberOfOutcomes";
            this.numericUpDownNumberOfOutcomes.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumberOfOutcomes.TabIndex = 7;
            this.numericUpDownNumberOfOutcomes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownNumberOfRounds
            // 
            this.numericUpDownNumberOfRounds.Location = new System.Drawing.Point(450, 120);
            this.numericUpDownNumberOfRounds.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownNumberOfRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfRounds.Name = "numericUpDownNumberOfRounds";
            this.numericUpDownNumberOfRounds.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumberOfRounds.TabIndex = 8;
            this.numericUpDownNumberOfRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonRename
            // 
            this.buttonRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRename.Location = new System.Drawing.Point(517, 177);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(171, 32);
            this.buttonRename.TabIndex = 9;
            this.buttonRename.Text = "Refactor -> Rename !";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.numericUpDownNumberOfRounds);
            this.Controls.Add(this.numericUpDownNumberOfOutcomes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNameEachOutcome);
            this.Controls.Add(this.labelNumberOfRepeats);
            this.Controls.Add(this.labelNumberOfOutcomes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfOutcomes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfRounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberOfOutcomes;
        private System.Windows.Forms.Label labelNumberOfRepeats;
        private System.Windows.Forms.Label labelNameEachOutcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfOutcomes;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfRounds;
        private System.Windows.Forms.Button buttonRename;
    }
}

