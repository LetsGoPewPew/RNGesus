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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameOutcomesForm));
            this.listViewOutcomes = new System.Windows.Forms.ListView();
            this.listBoxOutcomes = new System.Windows.Forms.ListBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonAddOutcome = new System.Windows.Forms.Button();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.textBoxCurrentUsedWeight = new System.Windows.Forms.TextBox();
            this.textBoxTotalWeight = new System.Windows.Forms.TextBox();
            this.buttonSaveAndExit = new System.Windows.Forms.Button();
            this.textBoxWeightExplaination = new System.Windows.Forms.TextBox();
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
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonAddOutcome
            // 
            this.buttonAddOutcome.Location = new System.Drawing.Point(656, 51);
            this.buttonAddOutcome.Name = "buttonAddOutcome";
            this.buttonAddOutcome.Size = new System.Drawing.Size(102, 23);
            this.buttonAddOutcome.TabIndex = 3;
            this.buttonAddOutcome.Text = "Add outcome";
            this.buttonAddOutcome.UseVisualStyleBackColor = true;
            this.buttonAddOutcome.Click += new System.EventHandler(this.buttonAddOutcome_Click);
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Location = new System.Drawing.Point(656, 92);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(102, 23);
            this.buttonRemoveSelected.TabIndex = 4;
            this.buttonRemoveSelected.Text = "Remove selected";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // textBoxCurrentUsedWeight
            // 
            this.textBoxCurrentUsedWeight.Location = new System.Drawing.Point(12, 400);
            this.textBoxCurrentUsedWeight.Name = "textBoxCurrentUsedWeight";
            this.textBoxCurrentUsedWeight.Size = new System.Drawing.Size(128, 20);
            this.textBoxCurrentUsedWeight.TabIndex = 5;
            this.textBoxCurrentUsedWeight.Text = "Current used weight: 0";
            // 
            // textBoxTotalWeight
            // 
            this.textBoxTotalWeight.Location = new System.Drawing.Point(316, 399);
            this.textBoxTotalWeight.Name = "textBoxTotalWeight";
            this.textBoxTotalWeight.Size = new System.Drawing.Size(128, 20);
            this.textBoxTotalWeight.TabIndex = 6;
            this.textBoxTotalWeight.Text = "Total weight: 0";
            // 
            // buttonSaveAndExit
            // 
            this.buttonSaveAndExit.Location = new System.Drawing.Point(656, 395);
            this.buttonSaveAndExit.Name = "buttonSaveAndExit";
            this.buttonSaveAndExit.Size = new System.Drawing.Size(102, 23);
            this.buttonSaveAndExit.TabIndex = 7;
            this.buttonSaveAndExit.Text = "Save and Exit";
            this.buttonSaveAndExit.UseVisualStyleBackColor = true;
            // 
            // textBoxWeightExplaination
            // 
            this.textBoxWeightExplaination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeightExplaination.Location = new System.Drawing.Point(450, 210);
            this.textBoxWeightExplaination.Multiline = true;
            this.textBoxWeightExplaination.Name = "textBoxWeightExplaination";
            this.textBoxWeightExplaination.Size = new System.Drawing.Size(199, 208);
            this.textBoxWeightExplaination.TabIndex = 9;
            this.textBoxWeightExplaination.Text = resources.GetString("textBoxWeightExplaination.Text");
            // 
            // RenameOutcomesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxWeightExplaination);
            this.Controls.Add(this.buttonSaveAndExit);
            this.Controls.Add(this.textBoxTotalWeight);
            this.Controls.Add(this.textBoxCurrentUsedWeight);
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
        private System.Windows.Forms.TextBox textBoxCurrentUsedWeight;
        private System.Windows.Forms.TextBox textBoxTotalWeight;
        private System.Windows.Forms.Button buttonSaveAndExit;
        private System.Windows.Forms.TextBox textBoxWeightExplaination;
    }
}