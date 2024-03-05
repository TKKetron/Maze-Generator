using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MazeLearning
{
    class Aldous_Broder_Maze : Maze
    {
        int visitCount;
        
        public Aldous_Broder_Maze(int width, int heigth) : base(width, heigth, true)
        {
            visitCount = 0;
            cells[currentCell.X, currentCell.Y].visit();
            visitCount++;
        }

        public override void IterateMaze()
        {
            if (isFinished())
                return;
            List<int> possibleCells = new List<int>();
            if (currentCell.X + 1 < width)
                possibleCells.Add(1);
            if (currentCell.X - 1 >= 0 )
                possibleCells.Add(3);
            if (currentCell.Y + 1 < height )
                possibleCells.Add(0);
            if (currentCell.Y - 1 >= 0 )
                possibleCells.Add(2);
            int dir = possibleCells[rand.Next(possibleCells.Count())];
            switch (dir)
            {
                case 0: //up
                    currentCell.Y++;
                    break;
                case 1:
                    currentCell.X++;
                    break;
                case 2:
                    currentCell.Y--;
                    break;
                case 3:
                    currentCell.X--;
                    break;
            }
            if (!cells[currentCell.X, currentCell.Y].isVisited())
            {
                switch (dir)
                {
                    case 0:
                        currentCell.Y--;
                        break;
                    case 1:
                        currentCell.X--;
                        break;
                    case 2:
                        currentCell.Y++;
                        break;
                    case 3:
                        currentCell.X++;
                        break;
                }
                cells[currentCell.X, currentCell.Y].InvertWall(dir);
                switch (dir)
                {
                    case 0: //up
                        currentCell.Y++;
                        break;
                    case 1:
                        currentCell.X++;
                        break;
                    case 2:
                        currentCell.Y--;
                        break;
                    case 3:
                        currentCell.X--;
                        break;
                }
                cells[currentCell.X, currentCell.Y].InvertWall((dir + 2) % 4);
                cells[currentCell.X, currentCell.Y].visit();
                visitCount++;
            }
            if (visitCount == width * height)
                Finish();
        }

        private void AldousVisit(Point cell)
        {
            cells[cell.X, cell.Y].visit();

        }
    }
}
