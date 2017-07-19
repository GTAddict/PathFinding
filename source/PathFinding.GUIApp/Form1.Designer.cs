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
            this.panel2 = new System.Windows.Forms.Panel();
            this.NumColumnsLabel = new System.Windows.Forms.Label();
            this.NumRowsLabel = new System.Windows.Forms.Label();
            this.NumColumnsEntry = new System.Windows.Forms.TextBox();
            this.NumRowsEntry = new System.Windows.Forms.TextBox();
            this.InstructionsText = new System.Windows.Forms.Label();
            this.BFS = new System.Windows.Forms.Button();
            this.Greedy = new System.Windows.Forms.Button();
            this.Dijkstra = new System.Windows.Forms.Button();
            this.AStar = new System.Windows.Forms.Button();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.AStar);
            this.panel2.Controls.Add(this.Dijkstra);
            this.panel2.Controls.Add(this.Greedy);
            this.panel2.Controls.Add(this.BFS);
            this.panel2.Controls.Add(this.NumColumnsLabel);
            this.panel2.Controls.Add(this.NumRowsLabel);
            this.panel2.Controls.Add(this.NumColumnsEntry);
            this.panel2.Controls.Add(this.NumRowsEntry);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 100);
            this.panel2.TabIndex = 2;
            // 
            // NumColumnsLabel
            // 
            this.NumColumnsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumColumnsLabel.AutoSize = true;
            this.NumColumnsLabel.Location = new System.Drawing.Point(872, 36);
            this.NumColumnsLabel.Name = "NumColumnsLabel";
            this.NumColumnsLabel.Size = new System.Drawing.Size(72, 13);
            this.NumColumnsLabel.TabIndex = 3;
            this.NumColumnsLabel.Text = "Num Columns";
            // 
            // NumRowsLabel
            // 
            this.NumRowsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumRowsLabel.AutoSize = true;
            this.NumRowsLabel.Location = new System.Drawing.Point(885, 8);
            this.NumRowsLabel.Name = "NumRowsLabel";
            this.NumRowsLabel.Size = new System.Drawing.Size(59, 13);
            this.NumRowsLabel.TabIndex = 2;
            this.NumRowsLabel.Text = "Num Rows";
            // 
            // NumColumnsEntry
            // 
            this.NumColumnsEntry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumColumnsEntry.Location = new System.Drawing.Point(950, 29);
            this.NumColumnsEntry.MaxLength = 2;
            this.NumColumnsEntry.Name = "NumColumnsEntry";
            this.NumColumnsEntry.Size = new System.Drawing.Size(31, 20);
            this.NumColumnsEntry.TabIndex = 1;
            // 
            // NumRowsEntry
            // 
            this.NumRowsEntry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumRowsEntry.Location = new System.Drawing.Point(950, 3);
            this.NumRowsEntry.MaxLength = 2;
            this.NumRowsEntry.Name = "NumRowsEntry";
            this.NumRowsEntry.Size = new System.Drawing.Size(31, 20);
            this.NumRowsEntry.TabIndex = 0;
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
            // BFS
            // 
            this.BFS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BFS.Location = new System.Drawing.Point(504, 3);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(75, 23);
            this.BFS.TabIndex = 4;
            this.BFS.Text = "BFS";
            this.BFS.UseVisualStyleBackColor = true;
            this.BFS.Click += new System.EventHandler(this.BFS_Click);
            // 
            // Greedy
            // 
            this.Greedy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Greedy.Location = new System.Drawing.Point(400, 3);
            this.Greedy.Name = "Greedy";
            this.Greedy.Size = new System.Drawing.Size(98, 23);
            this.Greedy.TabIndex = 5;
            this.Greedy.Text = "Greedy Best First";
            this.Greedy.UseVisualStyleBackColor = true;
            this.Greedy.Click += new System.EventHandler(this.Greedy_Click);
            // 
            // Dijkstra
            // 
            this.Dijkstra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dijkstra.Location = new System.Drawing.Point(319, 3);
            this.Dijkstra.Name = "Dijkstra";
            this.Dijkstra.Size = new System.Drawing.Size(75, 23);
            this.Dijkstra.TabIndex = 6;
            this.Dijkstra.Text = "Dijkstra\'s";
            this.Dijkstra.UseVisualStyleBackColor = true;
            this.Dijkstra.Click += new System.EventHandler(this.Dijkstra_Click);
            // 
            // AStar
            // 
            this.AStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AStar.Location = new System.Drawing.Point(238, 3);
            this.AStar.Name = "AStar";
            this.AStar.Size = new System.Drawing.Size(75, 23);
            this.AStar.TabIndex = 7;
            this.AStar.Text = "A*";
            this.AStar.UseVisualStyleBackColor = true;
            this.AStar.Click += new System.EventHandler(this.AStar_Click);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NumColumnsLabel;
        private System.Windows.Forms.Label NumRowsLabel;
        private System.Windows.Forms.TextBox NumColumnsEntry;
        private System.Windows.Forms.TextBox NumRowsEntry;
        private System.Windows.Forms.Button BFS;
        private System.Windows.Forms.Button Greedy;
        private System.Windows.Forms.Button Dijkstra;
        private System.Windows.Forms.Button AStar;
    }
}

