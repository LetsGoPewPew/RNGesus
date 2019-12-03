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
            this.listBoxOutcomes = new System.Windows.Forms.ListBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonAddOutcome = new System.Windows.Forms.Button();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.textBoxCurrentWeight = new System.Windows.Forms.TextBox();
            this.textBoxTargetWeight = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewOutcomes
            // 
            this.listViewOutcomes.HideSelection = false;
            this.listViewOutcomes.LabelEdit = true;
            this.listViewOutcomes.Location = new System.Drawing.Point(12, 12);
            this.listViewOutcomes.Name = "listViewOutcomes";
            this.listViewOutcomes.Size = new System.Drawing.Size(776, 426);
            this.listViewOutcomes.TabIndex = 0;
            this.listViewOutcomes.UseCompatibleStateImageBehavior = false;
            // 
            // listBoxOutcomes
            // 
            this.listBoxOutcomes.FormattingEnabled = true;
            this.listBoxOutcomes.Location = new System.Drawing.Point(12, 12);
            this.listBoxOutcomes.Name = "listBoxOutcomes";
            this.listBoxOutcomes.Size = new System.Drawing.Size(432, 381);
            this.listBoxOutcomes.TabIndex = 1;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(656, 172);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(102, 23);
            this.buttonRemoveAll.TabIndex = 2;
            this.buttonRemoveAll.Text = "Remove all";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            // 
            // buttonAddOutcome
            // 
            this.buttonAddOutcome.Location = new System.Drawing.Point(656, 51);
            this.buttonAddOutcome.Name = "buttonAddOutcome";
            this.buttonAddOutcome.Size = new System.Drawing.Size(102, 23);
            this.buttonAddOutcome.TabIndex = 3;
            this.buttonAddOutcome.Text = "Add outcome";
            this.buttonAddOutcome.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Location = new System.Drawing.Point(656, 92);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(102, 23);
            this.buttonRemoveSelected.TabIndex = 4;
            this.buttonRemoveSelected.Text = "Remove selected";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            // 
            // textBoxCurrentWeight
            // 
            this.textBoxCurrentWeight.Location = new System.Drawing.Point(12, 400);
            this.textBoxCurrentWeight.Name = "textBoxCurrentWeight";
            this.textBoxCurrentWeight.Size = new System.Drawing.Size(128, 20);
            this.textBoxCurrentWeight.TabIndex = 5;
            this.textBoxCurrentWeight.Text = "Current Weight: 0";
            // 
            // textBoxTargetWeight
            // 
            this.textBoxTargetWeight.Location = new System.Drawing.Point(316, 399);
            this.textBoxTargetWeight.Name = "textBoxTargetWeight";
            this.textBoxTargetWeight.Size = new System.Drawing.Size(128, 20);
            this.textBoxTargetWeight.TabIndex = 6;
            this.textBoxTargetWeight.Text = "Target Weight: 0";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(656, 395);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(102, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // RenameOutcomesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxTargetWeight);
            this.Controls.Add(this.textBoxCurrentWeight);
            this.Controls.Add(this.buttonRemoveSelected);
            this.Controls.Add(this.buttonAddOutcome);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.listBoxOutcomes);
            this.Controls.Add(this.listViewOutcomes);
            this.Name = "RenameOutcomesForm";
            this.Text = "RenameOutcomesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOutcomes;
        private System.Windows.Forms.ListBox listBoxOutcomes;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Button buttonAddOutcome;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.TextBox textBoxCurrentWeight;
        private System.Windows.Forms.TextBox textBoxTargetWeight;
        private System.Windows.Forms.Button buttonExit;
    }
}