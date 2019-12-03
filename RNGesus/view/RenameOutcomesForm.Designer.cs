namespace view
{
    partial class RenameOutcomesForm
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
            this.listViewOutcomes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewOutcomes
            // 
            this.listViewOutcomes.LabelEdit = true;
            this.listViewOutcomes.Location = new System.Drawing.Point(12, 12);
            this.listViewOutcomes.Name = "listViewOutcomes";
            this.listViewOutcomes.Size = new System.Drawing.Size(776, 426);
            this.listViewOutcomes.TabIndex = 0;
            this.listViewOutcomes.UseCompatibleStateImageBehavior = false;
            // 
            // RenameOutcomesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewOutcomes);
            this.Name = "RenameOutcomesForm";
            this.Text = "RenameOutcomesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOutcomes;
    }
}