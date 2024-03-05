
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MazeLearning
{
    public partial class Form : System.Windows.Forms.Form
    {
        Maze maze;
        A_Star_Solver solver;
        static Random rand;
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            rand = new Random();
            timer.Interval = 1000;
            timer.Tick += UpdateScreen;
            timer.Start();
        }
        private void UpdateScreen(object sender, EventArgs e)
        {

            if (maze != null)
                if (!maze.isFinished())
                    maze.IterateMaze();
            if (solver != null)
                if (!solver.IsSolved())
                    solver.IterateSolver();
            frame.Invalidate();
        }
        private void buttonGenerate_Click(object sender, System.EventArgs e)
        {
            if (!((int)widthCounter.Value > 0 && (int)heightCounter.Value > 0))
            {
                frame.Invalidate();
                return;
            }

            int width = (int)widthCounter.Value;
            int height = (int)heightCounter.Value;
            switch (MazeType.SelectedIndex)
            {
                case 1:
                    maze = new Iterative_Maze(width, height);
                    break;
                case 0:
                    maze = new Recursive_Maze(width, height);
                    break;
                case 2:
                    maze = new Wilson_Maze(width, height);
                    break;
                case 3:
                    maze = new Prim_Maze(width, height);
                    break;
                case 4:
                    maze = new Aldous_Broder_Maze(width, height);
                    break;
                case 5:
                    maze = new Kruskal_Maze(width, height);
                    break;
            }
            solver = null;
            startXCounter.Maximum = width;
            endXCounter.Maximum = width;
            startYCounter.Maximum = height;
            endYCounter.Maximum = height;


        }


        private void frame_Paint(object sender, PaintEventArgs e)
        {
            int length = 20;
            
            int width = 3;
            Color color = Color.Black;
            if (maze != null)
            {
                if (maze.GetHeight() >= maze.GetWidth())
                    length = (frame.Size.Height - 3 * (frame.Size.Height / maze.GetHeight())) / maze.GetHeight();
                else
                    length = (frame.Size.Width-3*(frame.Size.Width/maze.GetWidth())) / maze.GetWidth();
                Cell[,] cells = maze.getCells();
                Point current = maze.GetCurrentCell();
                Graphics g = e.Graphics;
                foreach (Cell cell in cells)
                {
                    
                    if (!maze.isFinished())
                    {
                        if (cell.getCords().Equals(current))
                            g.FillRectangle(Brushes.Red, new Rectangle(new Point((current.X + 1) * length, (current.Y + 1) * length), new Size(length, length)));
                    }
                    else if (solver != null)
                    {
                        if(solver.IsInSolved(cell.getCords()))
                            g.FillRectangle(Brushes.Blue, new Rectangle(new Point((cell.getCords().X + 1) * length, (cell.getCords().Y + 1) * length), new Size(length, length)));
                        else if (cell.getCords().Equals(solver.GetStart()))
                            g.FillRectangle(Brushes.Blue, new Rectangle(new Point((cell.getCords().X + 1) * length, (cell.getCords().Y + 1) * length), new Size(length, length)));
                        else if (cell.getCords().Equals(solver.GetEnd()))
                            g.FillRectangle(Brushes.Purple, new Rectangle(new Point((cell.getCords().X + 1) * length, (cell.getCords().Y + 1) * length), new Size(length, length)));
                        else if (solver.IsInClosed(cell.getCords()))
                            g.FillRectangle(Brushes.Red, new Rectangle(new Point((cell.getCords().X + 1) * length, (cell.getCords().Y + 1) * length), new Size(length, length)));
                        else if (solver.IsInOpen(cell.getCords()))
                            g.FillRectangle(Brushes.Green, new Rectangle(new Point((cell.getCords().X + 1) * length, (cell.getCords().Y + 1) * length), new Size(length, length)));

                    }
                    if(cell.isSpecail())
                        g.FillRectangle(Brushes.Crimson, new Rectangle(new Point((cell.getCords().X + 1) * length, (cell.getCords().Y + 1) * length), new Size(length, length)));


                    for (int i = 0; i < 4; i++)
                    {

                        if (cell.getWalls()[i])
                            switch (i)
                            {
                                case 0:
                                    g.DrawLine(new Pen(color, width), (cell.getCords().X + 1) * length, (cell.getCords().Y + 2) * length, (cell.getCords().X + 1) * length + length, (cell.getCords().Y + 2) * length);
                                    break;
                                case 1:
                                    g.DrawLine(new Pen(color, width), (cell.getCords().X + 1) * length + length, (cell.getCords().Y + 2) * length, (cell.getCords().X + 1) * length + length, (cell.getCords().Y + 2) * length - length);
                                    break;
                                case 2:
                                    g.DrawLine(new Pen(color, width), (cell.getCords().X + 1) * length + length, (cell.getCords().Y + 2) * length - length, (cell.getCords().X + 1) * length, (cell.getCords().Y + 2) * length - length);

                                    break;
                                case 3:
                                    g.DrawLine(new Pen(color, width), (cell.getCords().X + 1) * length, (cell.getCords().Y + 2) * length - length, (cell.getCords().X + 1) * length, (cell.getCords().Y + 2) * length);
                                    break;

                            }
                    }
                }

            }

        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (maze == null)
                return;
            if (maze.isFinished())
                return;
            timer.Stop();
            while (!maze.isFinished())
                maze.IterateMaze();
            timer.Start();
        }

        private void speedSlider_ValueChanged(object sender, System.EventArgs e)
        {
            labelSpeedValue.Text = speedSlider.Value.ToString();
            if (speedSlider.Value == 0)
                timer.Stop();
            else
            {
                timer.Start();
                timer.Interval = (100 - speedSlider.Value + 1);
            }
        }

        private void buttonFindPath_Click(object sender, EventArgs e)
        {
            if (maze != null)
                if(maze.isFinished())
                    solver = new A_Star_Solver(new Point((int)startXCounter.Value-1, (int)startYCounter.Value-1), new Point((int)endXCounter.Value-1, (int)endYCounter.Value-1), maze);
        }

        private void buttonFinishPath_Click(object sender, EventArgs e)
        {
            if(solver != null)
                while(!solver.IsSolved())
                    solver.IterateSolver();
        }

        private void buttonClearSolver_Click(object sender, EventArgs e)
        {
            solver = null;
        }

        private void buttonRAND_Click(object sender, EventArgs e)
        {
            startXCounter.Value = rand.Next((int)startXCounter.Maximum);
            startYCounter.Value = rand.Next((int)startYCounter.Maximum);
            endXCounter.Value = rand.Next((int)endXCounter.Maximum);
            endYCounter.Value = rand.Next((int)endYCounter.Maximum);


        }

        private void buttonMakeRoom_Click(object sender, EventArgs e)
        {
            if (maze == null)
                return;

            int sizeX = rand.Next(2,maze.GetWidth() / 5);
            int sizeY = rand.Next(2,maze.GetHeight() / 5);
            int startX = rand.Next(1,maze.GetWidth()-1 - sizeX);
            int startY = rand.Next(1,maze.GetHeight()-1 - sizeY);
            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j <   sizeY; j++)
                {
                    maze.RemoveWall(startX+i, startY+j);
                    maze.RemoveWall(startX + i+1, startY + j);
                    maze.RemoveWall(startX + i, startY + j+1);
                    maze.RemoveWall(startX + i+1, startY + j+1);

                }
        }

        private void buttonAddItems_Click(object sender, EventArgs e)
        {
            if (maze == null)
                return;
            for (int i = 0; i < (int)(maze.GetHeight() * maze.GetWidth() * .01 + .5); i++)
                maze.MakeSpecial(rand.Next(maze.GetWidth()),rand.Next( maze.GetHeight()));
        }
    }
}
