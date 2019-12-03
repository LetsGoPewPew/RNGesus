namespace view
{
    partial class AddOutcomeForm
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
            this.buttonDone = new System.Windows.Forms.Button();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescriptionName = new System.Windows.Forms.TextBox();
            this.textBoxDescriptionWeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(47, 219);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(202, 35);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWeight.Location = new System.Drawing.Point(149, 142);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(142, 23);
            this.numericUpDownWeight.TabIndex = 1;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(149, 58);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(142, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxDescriptionName
            // 
            this.textBoxDescriptionName.Location = new System.Drawing.Point(12, 58);
            this.textBoxDescriptionName.Name = "textBoxDescriptionName";
            this.textBoxDescriptionName.ReadOnly = true;
            this.textBoxDescriptionName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescriptionName.TabIndex = 3;
            this.textBoxDescriptionName.Text = "Name:";
            // 
            // textBoxDescriptionWeight
            // 
            this.textBoxDescriptionWeight.Location = new System.Drawing.Point(12, 142);
            this.textBoxDescriptionWeight.Name = "textBoxDescriptionWeight";
            this.textBoxDescriptionWeight.ReadOnly = true;
            this.textBoxDescriptionWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescriptionWeight.TabIndex = 5;
            this.textBoxDescriptionWeight.Text = "Weight:";
            // 
            // AddOutcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 316);
            this.Controls.Add(this.textBoxDescriptionWeight);
            this.Controls.Add(this.textBoxDescriptionName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.buttonDone);
            this.Name = "AddOutcomeForm";
            this.Text = "AddOutcomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescriptionName;
        private System.Windows.Forms.TextBox textBoxDescriptionWeight;
    }
}