using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MazeLearning
{
    public class Iterative_Maze : Maze
    {


        private Stack<Point> cellStack;

        public Iterative_Maze(int width, int heigth) : base(width, heigth, true)
        {
            cellStack = new Stack<Point>();
            cells[currentCell.X, currentCell.Y].visit();
            cellStack.Push(cells[currentCell.X, currentCell.Y].getCords());


        }

        public override void IterateMaze()
        {
            if (isFinished())
                return;
            if (cellStack.Count == 0)
            {
                Finish();
                return;
            }
            List<int> possibleCells = new List<int>();

            possibleCells.Clear();
            if (currentCell.X + 1 < width && !cells[currentCell.X + 1, currentCell.Y].isVisited())
                possibleCells.Add(1);
            if (currentCell.X - 1 >= 0 && !cells[currentCell.X - 1, currentCell.Y].isVisited())
                possibleCells.Add(3);
            if (currentCell.Y + 1 < height && !cells[currentCell.X, currentCell.Y + 1].isVisited())
                possibleCells.Add(0);
            if (currentCell.Y - 1 >= 0 && !cells[currentCell.X, currentCell.Y - 1].isVisited())
                possibleCells.Add(2);
            if (possibleCells.Count == 0)
            {
                currentCell = cellStack.Pop();
                return;
            }
            visitCell(possibleCells[rand.Next(possibleCells.Count())]);
            
        }


        private void visitCell(int dir)
        {
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
            cellStack.Push(cells[currentCell.X, currentCell.Y].getCords());
        }


    }
}
