using System.Collections.Generic;
using System.Drawing;

namespace MazeLearning
{
    public class Prim_Maze : Maze
    {
        private struct Wall
        {
            private int side;
            private Point cell;
            public Wall(int side, Point cell)
            {
                this.side = side;
                this.cell = cell;
            }
            public int getSide()
            {
                return side;
            }

            public Point getCell()
            {
                return cell;
            }
        }
        List<Wall> walls;
        public Prim_Maze(int width, int height): base(width, height, true)
        {
            walls = new List<Wall>();
            cells[currentCell.X, currentCell.Y].visit();
            for (int i = 0; i < 4; i++)
            {
                if (currentCell.X == 0 && i == 3)
                    continue;
                if (currentCell.X == width - 1 && i == 1)
                    continue;
                if (currentCell.Y == height - 1 && i == 0)
                    continue;
                if (currentCell.Y == 0 && i == 2)
                    continue;
                walls.Add(new Wall(i, currentCell));
            }
        }

        public override void IterateMaze()
        {
            if (isFinished())
                return;
            Wall current = walls[rand.Next(walls.Count)];
            currentCell = current.getCell();
            switch (current.getSide())
            {
                case 0:
                    if (current.getCell().Y + 1 < height)
                        if (!cells[currentCell.X, currentCell.Y + 1].isVisited())
                            PrimsRemoveWall(current.getSide());
                    break;
                case 1:
                    if (current.getCell().X + 1 < width)
                        if (!cells[currentCell.X + 1, currentCell.Y].isVisited())
                            PrimsRemoveWall(current.getSide());
                    break;
                case 2:
                    if (current.getCell().Y - 1 >= 0)
                        if (!cells[currentCell.X, currentCell.Y - 1].isVisited())
                            PrimsRemoveWall(current.getSide());
                    break;
                case 3:
                    if (current.getCell().X - 1 >= 0)
                        if (!cells[currentCell.X - 1, currentCell.Y].isVisited())
                            PrimsRemoveWall(current.getSide());
                    break;
            }
            walls.Remove(current);
            if (walls.Count == 0)
                Finish();
        }


        private void PrimsRemoveWall(int dir)
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
            for (int i = 0; i < 4; i++)
                if (cells[currentCell.X, currentCell.Y].getWalls()[i])
                {
                    if (currentCell.X == 0 && i == 3)
                        continue;
                    if (currentCell.X == width - 1 && i == 1)
                        continue;
                    if (currentCell.Y == height - 1 && i == 0)
                        continue;
                    if (currentCell.Y == 0 && i == 2)
                        continue;
                    walls.Add(new Wall(i, currentCell));
                }
        }
    }
}
