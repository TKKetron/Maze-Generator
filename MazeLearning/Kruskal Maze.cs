using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLearning
{
    public class Kruskal_Maze : Maze
    {
        
        private class Wall
        {
            private int side;
            private Point cell;
            private int group;

            public Wall(int side, Point cell, int width)
            {
                this.side = side;
                this.cell = cell;
                group = cell.Y * width + cell.X;
            }
            public int getSide()
            {
                return side;
            }

            public Point getCell()
            {
                return cell;
            }
            public void ChangeGroup(int group)
            {
                this.group = group;
            }

            public int GetGroup()
            {
                return group;
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                Wall other = (Wall)obj;
                if (cell.Equals(other.getCell()) && side == other.getSide())
                    return true;
                else
                    return false;
            }
        }
        List<Wall> walls;
        public Kruskal_Maze(int width, int height) : base(width, height, true)
        {
            walls = new List<Wall>();
            foreach (Cell cell in cells)
            {
                for (int i = 0; i < 4; i++)
                    if (cell.getWalls()[i])
                    {
                        if (cell.getCords().X == 0 && i == 3)
                            continue;
                        if (cell.getCords().X == width - 1 && i == 1)
                            continue;
                        if (cell.getCords().Y == height - 1 && i == 0)
                            continue;
                        if (cell.getCords().Y == 0 && i == 2)
                            continue;
                        walls.Add(new Wall(i, cell.getCords(), width));
                    }
            }
            
        }

        public override void IterateMaze()
        {
            if (isFinished())
                return;
            Wall wall = walls[rand.Next(walls.Count)];
            switch (wall.getSide())
            {
                case 0: //up
                    currentCell = new Point(wall.getCell().X,wall.getCell().Y+1);
                    break;
                case 1:
                    currentCell = new Point(wall.getCell().X + 1, wall.getCell().Y);
                    break;
                case 2:
                    currentCell = new Point(wall.getCell().X, wall.getCell().Y - 1);
                    break;
                case 3:
                    currentCell = new Point(wall.getCell().X - 1, wall.getCell().Y);
                    break;
            }

            Wall neighbor = walls.Find(x => x.getCell() == currentCell && x.getSide() == (wall.getSide() + 2) % 4);

            if (wall.GetGroup() != neighbor.GetGroup())
            {
                cells[wall.getCell().X, wall.getCell().Y].InvertWall(wall.getSide());
                cells[neighbor.getCell().X, neighbor.getCell().Y].InvertWall(neighbor.getSide());
                foreach (Wall w in walls.FindAll(x => x.GetGroup() == neighbor.GetGroup()))
                    w.ChangeGroup(wall.GetGroup());
            }

            walls.Remove(wall);
            walls.Remove(neighbor);

            if (walls.Count == 0)
                Finish();
        }
    }
}
