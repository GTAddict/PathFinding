using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathFinding.GUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int f = 1;

            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    Button button = new Button();
                    buttons.Add(button);
                    this.Grid.Controls.Add(button);
                    button.Dock = System.Windows.Forms.DockStyle.Top;
                    button.Location = new System.Drawing.Point(0, 0);
                    button.Name = "button" + f.ToString();
                    ++f;
                    button.Size = new System.Drawing.Size((this.Grid.ClientSize.Width - tolerance) / row, (this.Grid.ClientSize.Height - tolerance) / col);
                    button.Text = f.ToString();
                    button.UseVisualStyleBackColor = true;
                }
            }

            this.Grid.SizeChanged += FlowLayoutPanel1_SizeChanged;
            this.NumRowsEntry.TextChanged += RowColumnNumTextChanged;
            this.NumColumnsEntry.TextChanged += RowColumnNumTextChanged;
            this.InstructionsText.Text = "LMB to place start node.\nRMB to place end node.\nMMB to place obstacle.";
        }

        private void RowColumnNumTextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(NumRowsEntry.Text, out row) && int.TryParse(NumColumnsEntry.Text, out col) && row > 0 && col > 0)
            {
                this.Grid.Controls.Clear();
                buttons.Clear();

                int ID = 0;
                for (int i = 0; i < row; ++i)
                {
                    for (int j = 0; j < col; ++j)
                    {
                        Button button = new Button();
                        buttons.Add(button);
                        this.Grid.Controls.Add(button);
                        button.Dock = System.Windows.Forms.DockStyle.Top;
                        button.Location = new System.Drawing.Point(0, 0);
                        button.Name = "button" + ID.ToString();
                        button.Size = new System.Drawing.Size((this.Grid.ClientSize.Width - tolerance) / row, (this.Grid.ClientSize.Height - tolerance) / col);
                        button.Text = ID.ToString();
                        ++ID;
                        button.UseVisualStyleBackColor = true;
                    }
                }

                UpdateButtons();
            }
            else
            {
                NumRowsEntry.Text = row.ToString();
                NumColumnsEntry.Text = col.ToString();
            }
        }

        private void FlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            foreach (Button button in buttons)
            {
                button.Size = new System.Drawing.Size((this.Grid.ClientSize.Width - tolerance) / row, (this.Grid.ClientSize.Height - tolerance) / col);
            }
        }

        List<Button> buttons = new List<Button>();
        int row = 3;
        int col = 3;
        int tolerance = 17;
    }
}
