namespace PathFinding.GUIApp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Grid = new System.Windows.Forms.FlowLayoutPanel();
            this.InstructionsText = new System.Windows.Forms.Label();
            this.AlgorithmSelectionBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NumRowsEntry = new System.Windows.Forms.TextBox();
            this.NumColumnsEntry = new System.Windows.Forms.TextBox();
            this.NumRowsLabel = new System.Windows.Forms.Label();
            this.NumColumnsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 961);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Grid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.AlgorithmSelectionBox);
            this.splitContainer1.Panel2.Controls.Add(this.InstructionsText);
            this.splitContainer1.Size = new System.Drawing.Size(984, 961);
            this.splitContainer1.SplitterDistance = 851;
            this.splitContainer1.TabIndex = 0;
            // 
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(984, 851);
            this.Grid.TabIndex = 0;
            // 
            // InstructionsText
            // 
            this.InstructionsText.AutoSize = true;
            this.InstructionsText.Dock = System.Windows.Forms.DockStyle.Left;
            this.InstructionsText.Location = new System.Drawing.Point(0, 0);
            this.InstructionsText.Name = "InstructionsText";
            this.InstructionsText.Size = new System.Drawing.Size(0, 13);
            this.InstructionsText.TabIndex = 0;
            // 
            // AlgorithmSelectionBox
            // 
            this.AlgorithmSelectionBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AlgorithmSelectionBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AlgorithmSelectionBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.AlgorithmSelectionBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AlgorithmSelectionBox.FormattingEnabled = true;
            this.AlgorithmSelectionBox.Location = new System.Drawing.Point(863, 0);
            this.AlgorithmSelectionBox.Name = "AlgorithmSelectionBox";
            this.AlgorithmSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.AlgorithmSelectionBox.TabIndex = 1;
            this.AlgorithmSelectionBox.Text = "Select Algorithm...";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NumColumnsLabel);
            this.panel2.Controls.Add(this.NumRowsLabel);
            this.panel2.Controls.Add(this.NumColumnsEntry);
            this.panel2.Controls.Add(this.NumRowsEntry);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 100);
            this.panel2.TabIndex = 2;
            // 
            // NumRowsEntry
            // 
            this.NumRowsEntry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumRowsEntry.Location = new System.Drawing.Point(829, 3);
            this.NumRowsEntry.MaxLength = 2;
            this.NumRowsEntry.Name = "NumRowsEntry";
            this.NumRowsEntry.Size = new System.Drawing.Size(31, 20);
            this.NumRowsEntry.TabIndex = 0;
            // 
            // NumColumnsEntry
            // 
            this.NumColumnsEntry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumColumnsEntry.Location = new System.Drawing.Point(829, 29);
            this.NumColumnsEntry.MaxLength = 2;
            this.NumColumnsEntry.Name = "NumColumnsEntry";
            this.NumColumnsEntry.Size = new System.Drawing.Size(31, 20);
            this.NumColumnsEntry.TabIndex = 1;
            // 
            // NumRowsLabel
            // 
            this.NumRowsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumRowsLabel.AutoSize = true;
            this.NumRowsLabel.Location = new System.Drawing.Point(764, 8);
            this.NumRowsLabel.Name = "NumRowsLabel";
            this.NumRowsLabel.Size = new System.Drawing.Size(59, 13);
            this.NumRowsLabel.TabIndex = 2;
            this.NumRowsLabel.Text = "Num Rows";
            // 
            // NumColumnsLabel
            // 
            this.NumColumnsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumColumnsLabel.AutoSize = true;
            this.NumColumnsLabel.Location = new System.Drawing.Point(751, 36);
            this.NumColumnsLabel.Name = "NumColumnsLabel";
            this.NumColumnsLabel.Size = new System.Drawing.Size(72, 13);
            this.NumColumnsLabel.TabIndex = 3;
            this.NumColumnsLabel.Text = "Num Columns";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel Grid;
        private System.Windows.Forms.Label InstructionsText;
        private System.Windows.Forms.ComboBox AlgorithmSelectionBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NumColumnsLabel;
        private System.Windows.Forms.Label NumRowsLabel;
        private System.Windows.Forms.TextBox NumColumnsEntry;
        private System.Windows.Forms.TextBox NumRowsEntry;
    }
}

