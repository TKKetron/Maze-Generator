using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MazeLearning
{
    public class Wilson_Maze : Maze
    {

        List<Cell> inMaze;

        List<Point> maybeInMaze;
        List<Point> possiblePoints;

        public Wilson_Maze(int width, int height) : base(width, height, true)
        {
            inMaze = new List<Cell>();

            maybeInMaze = new List<Point>();
            possiblePoints = new List<Point>();

            foreach (Cell c in cells)
                possiblePoints.Add(c.getCords());

            WilsonVisit(currentCell);

        }

        private void WilsonVisit(Point cell)
        {
            possiblePoints.Remove(cell);
            cells[cell.X, cell.Y].visit();
            inMaze.Add(cells[cell.X, cell.Y]);
        }

        public override void IterateMaze()
        {
            if (isFinished())
                return;
            int dir = -1;
            List<int> possibleCells = new List<int>();

            maybeInMaze.Clear();

            currentCell = possiblePoints[rand.Next(possiblePoints.Count)];
            maybeInMaze.Add(currentCell);

            while (!inMaze.Contains(cells[currentCell.X, currentCell.Y]))
            {
                possibleCells.Clear();

                if (currentCell.X + 1 < width  && dir != 3)
                    possibleCells.Add(1);
                if (currentCell.X - 1 >= 0  && dir != 1)
                    possibleCells.Add(3);
                if (currentCell.Y + 1 < height  && dir != 2)
                    possibleCells.Add(0);
                if (currentCell.Y - 1 >= 0  && dir != 0)
                    possibleCells.Add(2);

                switch (possibleCells[rand.Next(possibleCells.Count)])
                {
                    case 0: //up
                        dir = 0;
                        currentCell.Y++;
                        break;
                    case 1:
                        dir = 1;
                        currentCell.X++;
                        break;
                    case 2:
                        dir = 2;
                        currentCell.Y--;
                        break;
                    case 3:
                        dir = 3;
                        currentCell.X--;
                        break;
                }
                if (maybeInMaze.Contains(currentCell))
                    while (maybeInMaze.Last() != currentCell)
                        maybeInMaze.RemoveAt(maybeInMaze.Count - 1);
                else
                    maybeInMaze.Add(currentCell);
            }
            AddToMaze();
            if (inMaze.Count == width * height)
                Finish();
        }

        private void AddToMaze()
        {
            for (int i = 0; i < maybeInMaze.Count-1; i++)
            {
                int dir;
                if (maybeInMaze[i].X - maybeInMaze[i + 1].X != 0)
                    dir = maybeInMaze[i].X - maybeInMaze[i + 1].X+2;
                else
                    dir = maybeInMaze[i].Y - maybeInMaze[i + 1].Y+1;

                cells[maybeInMaze[i].X, maybeInMaze[i].Y].InvertWall(dir);

                cells[maybeInMaze[i+1].X, maybeInMaze[i+1].Y].InvertWall((dir + 2) % 4);
                WilsonVisit(maybeInMaze[i]);
            }
        }
    }
}
