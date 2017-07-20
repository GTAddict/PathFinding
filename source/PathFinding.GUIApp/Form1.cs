using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Cli;

namespace PathFinding.GUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Grid.SizeChanged += FlowLayoutPanel1_SizeChanged;
            this.NumRowsEntry.Leave += RowColumnNumTextChanged;
            this.NumColumnsEntry.Leave += RowColumnNumTextChanged;
            this.InstructionsText.Text = "LMB to place start node.\nRMB to place end node.\nMMB to place obstacle or revert to empty space.";

            NumRowsEntry.Text = row.ToString();
            NumColumnsEntry.Text = col.ToString();

            RowColumnNumTextChanged(this, null);
        }

        private void Button_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        Button b = sender as Button;
                        int x, y;
                        GetButtonGraphCoords(b, out x, out y);

                        if (graph[x, y].Type != ManagedNodeType.Start)
                        {
                            if (start != invalidPoint)
                            {
                                graph[start.X, start.Y].Type = ManagedNodeType.Normal;
                            }
                            graph[x, y].Type = ManagedNodeType.Start;
                            start = new ManagedPoint(x, y);
                        }
                        else
                        {
                            graph[x, y].Type = ManagedNodeType.Normal;
                            start = invalidPoint;
                        }
                    }
                    break;

                case MouseButtons.Right:
                    {
                        Button b = sender as Button;
                        int x, y;
                        GetButtonGraphCoords(b, out x, out y);

                        if (graph[x, y].Type != ManagedNodeType.End)
                        {
                            if (end != invalidPoint)
                            {
                                graph[end.X, end.Y].Type = ManagedNodeType.Normal;
                            }
                            graph[x, y].Type = ManagedNodeType.End;
                            end = new ManagedPoint(x, y);
                        }
                        else
                        {
                            graph[x, y].Type = ManagedNodeType.Normal;
                            end = invalidPoint;
                        }
                    }
                    break;

                case MouseButtons.Middle:
                    {
                        Button b = sender as Button;
                        int x, y;
                        GetButtonGraphCoords(b, out x, out y);
                        ManagedPoint Point = new ManagedPoint(x, y);
                        if (graph[x, y].Type == ManagedNodeType.Wall)
                        {
                            graph[x, y].Type = ManagedNodeType.Normal;
                        }
                        else
                        {
                            graph[Point].Type = ManagedNodeType.Wall;
                            if (start == Point)
                            {
                                start = invalidPoint;
                            }
                            else if (end == Point)
                            {
                                end = invalidPoint;
                            }
                        }
                    }
                    break;
            }

            UpdateTextures();
        }

        private void RowColumnNumTextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(NumRowsEntry.Text, out row) && int.TryParse(NumColumnsEntry.Text, out col) && row > 0 && col > 0)
            {
                this.Grid.Controls.Clear();
                buttons.Clear();
                start = new ManagedPoint(-1, -1);
                end = new ManagedPoint(-1, -1);

                graph = ManagedGridHelper.CreateGrid(col, row);
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
                        button.Name = ID.ToString();
                        ++ID;
                        button.UseVisualStyleBackColor = true;
                        button.MouseDown += Button_MouseClick;
                    }
                }

                horizontalTolerance = buttons[0].Margin.Horizontal * row;
                verticalTolerance = buttons[0].Margin.Vertical * col;

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
                int width = (this.Grid.ClientSize.Width - horizontalTolerance) / row;
                int height = (this.Grid.ClientSize.Height - verticalTolerance) / col;
                button.Size = new System.Drawing.Size(width, height);
            }
        }

        private void UpdateTextures()
        {
            foreach (Button button in buttons)
            {
                int x, y;
                GetButtonGraphCoords(button, out x, out y);
                switch (graph[x, y].Type)
                {
                    case ManagedNodeType.Start:
                        {
                            button.Image = House;
                        }
                        break;

                    case ManagedNodeType.End:
                        {
                            button.Image = Flag;
                        }
                        break;

                    case ManagedNodeType.Wall:
                        {
                            button.Image = Wall;
                        }
                        break;

                    case ManagedNodeType.Normal:
                        {
                            button.Image = null;
                        }
                        break;
                }
            }
        }

        void UpdatePath(ICollection<ManagedNode> nodes, ICollection<ManagedNode> visitedNodes)
        {
            UpdateTextures();

            foreach (var node in visitedNodes)
            {
                if (node.Location != start && node.Location != end)
                {
                    GetButtonForCoords(node.Location.X, node.Location.Y).Image = Eyes;
                }
            }

            if (nodes.Count == 0)
            {
                MessageBox.Show("No path found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (var node in nodes)
                {
                    if (node.Location != start && node.Location != end)
                    {
                        GetButtonForCoords(node.Location.X, node.Location.Y).Image = Feet;
                    }
                }
            }
        }

        bool IsValidPathfindRequest()
        {
            if (start == invalidPoint || end == invalidPoint)
            {
                return false;
            }

            return true;
        }

        void PathFind(PathFindType type)
        {
            if (IsValidPathfindRequest())
            {
                ICollection<ManagedNode> closedSet = new List<ManagedNode>();
                UpdatePath(pathFinders[type].FindPathA(graph, graph[start], graph[end], out closedSet), closedSet);
            }
            else
            {
                MessageBox.Show("The start or end point is not set!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BFS_Click(object sender, EventArgs e)
        {
            PathFind(PathFindType.BFS);
        }

        private void Greedy_Click(object sender, EventArgs e)
        {
            PathFind(PathFindType.GreedyBreadthFirst);
        }

        private void Dijkstra_Click(object sender, EventArgs e)
        {
            PathFind(PathFindType.Dijkstra);
        }

        private void AStar_Click(object sender, EventArgs e)
        {
            PathFind(PathFindType.AStar);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    graph[j, i].Type = ManagedNodeType.Normal;
                }
            }

            start = end = invalidPoint;

            UpdateTextures();
        }

        Button GetButtonForCoords(int x, int y)
        {
            return buttons[y * col + x];
        }

        private void GetButtonGraphCoords(Button b, out int x, out int y)
        {
            int ID = int.Parse(b.Name);
            x = ID % col;
            y = ID / col;
        }

        List<Button> buttons = new List<Button>();
        int row = 5;
        int col = 5;
        int horizontalTolerance = 0;
        int verticalTolerance = 0;

        Image Flag = Image.FromFile("Content\\flag.png");
        Image House = Image.FromFile("Content\\house.png");
        Image Wall = Image.FromFile("Content\\wall.png");
        Image Feet = Image.FromFile("Content\\feet.png");
        Image Eyes = Image.FromFile("Content\\eyes.png");

        ManagedGraph graph;
        ManagedPoint invalidPoint = new ManagedPoint(-1, -1);
        ManagedPoint start = new ManagedPoint(-1, -1);
        ManagedPoint end = new ManagedPoint(-1, -1);

        Dictionary<PathFindType, PathFinder> pathFinders = new Dictionary<PathFindType, PathFinder>()
        {
            { PathFindType.BFS,                 new PathFinder(PathFindType.BFS)                },
            { PathFindType.GreedyBreadthFirst,  new PathFinder(PathFindType.GreedyBreadthFirst) },
            { PathFindType.Dijkstra,            new PathFinder(PathFindType.Dijkstra)           },
            { PathFindType.AStar,               new PathFinder(PathFindType.AStar)              }
        };
    }
}
