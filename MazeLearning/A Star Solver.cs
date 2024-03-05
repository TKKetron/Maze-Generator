using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MazeLearning
{

    class A_Star_Solver
    {
        private class ACell : IComparable<ACell>
        {
            private static Point end;
            Point parent;
            Cell cell;
            int gCost;
            int hCost;
            int fCost;
            List<int> dirs;

            public ACell(Cell cell, Point? parent = null)
            {
                dirs = new List<int>();
                this.cell = cell;
                hCost = (int)((Math.Pow(cell.getCords().X - end.X, 2) + Math.Pow(cell.getCords().Y - end.Y, 2)) * 10);

                if (parent != null)
                {
                    this.parent = (Point)parent;
                    gCost = (int)((Math.Pow(cell.getCords().X - this.parent.X, 2) + Math.Pow(cell.getCords().Y - this.parent.Y, 2)) * 10);
                    fCost = gCost + hCost;
                }
            }
            public void updateCosts(Point parent, int dir, int parentGCost)
            {
                this.parent = parent;
                gCost = (int)((Math.Pow(cell.getCords().X - parent.X, 2) + Math.Pow(cell.getCords().Y - parent.Y, 2)) * 10) + parentGCost;
                fCost = gCost + hCost;
                dirs.Add(dir);
            }
            public int GetGCost()
            {
                return gCost;
            }
            public static void SetPoints(Point pointE)
            {
                end = pointE;
            }

            public bool CheckDir(int dir)
            {
                if (dirs.Contains((dir + 2) % 4) || cell.getWalls()[dir])
                    return false;
                else
                    return true;
            }

            public int GetFCost()
            {
                return fCost;
            }
            public int GetHCost()
            {
                return hCost;
            }
            public Point GetCords()
            {
                return cell.getCords();
            }
            public Point GetParent()
            {
                return parent;
            }
            public int CompareTo(ACell other)
            {
                if (GetFCost() < other.GetFCost())
                    return -1;
                else if (GetFCost() > other.GetFCost())
                    return 1;
                else if (GetHCost() > other.GetHCost())
                    return -1;
                else
                    return 1;
            }
        }
        private List<ACell> open;
        private List<ACell> closed;
        private Point end;
        private Point start;

        List<Point> solvedPath;
        private bool solved;
        private bool solving;
        private Point current;

        private ACell[,] cells;

        public A_Star_Solver(Point start, Point end, Maze maze)
        {
            ACell.SetPoints(end);

            cells = new ACell[maze.GetWidth(),maze.GetHeight()];
            open = new List<ACell>();
            closed = new List<ACell>();

            solved = false;
            solving = false;
            solvedPath = new List<Point>();

            this.start = start;
            this.end = end;


            for (int i = 0; i < maze.GetWidth(); i++)
                for (int j = 0; j < maze.GetHeight(); j++)
                    cells[i, j] = new ACell(maze.getCells()[i, j], null);

            for (int i = 0; i < 4; i++)
                if (!maze.getCells()[start.X, start.Y].getWalls()[i])
                    switch (i)
                    {
                        case 0:
                            open.Add(cells[start.X, start.Y + 1]);
                            open[^1].updateCosts(start, i,0);
                            break;
                        case 1:
                            open.Add(cells[start.X + 1, start.Y]);
                            open[^1].updateCosts(start, i,0);
                            break;
                        case 2:
                            open.Add(cells[start.X, start.Y - 1]);
                            open[^1].updateCosts(start, i,0);

                            break;
                        case 3:
                            open.Add(cells[start.X - 1, start.Y]);
                            open[^1].updateCosts(start, i,0);
                            break;
                    }
            if (start.Equals(end))
                solved = true;

        }

        public void IterateSolver()
        {
            
            if (solved)
                return;
            if (solving)
            {
                Solve();
                return;
            }
            open.Sort();
            ACell current = open[0];
            open.Remove(current);
            closed.Add(current);

            

            for (int i = 0; i < 4; i++)
                if (current.CheckDir(i))
                    switch (i)
                    {
                        case 0:
                            if (open.Contains(cells[current.GetCords().X, current.GetCords().Y + 1]))
                                open.Remove(cells[current.GetCords().X, current.GetCords().Y + 1]);
                            cells[current.GetCords().X,current.GetCords().Y+1].updateCosts(current.GetCords(), i, cells[current.GetCords().Y, current.GetCords().Y].GetGCost());
                            open.Add(cells[current.GetCords().X, current.GetCords().Y+1]);
                            break;
                        case 1:
                            if (open.Contains(cells[current.GetCords().X+1, current.GetCords().Y]))
                                open.Remove(cells[current.GetCords().X+1, current.GetCords().Y]);
                            cells[current.GetCords().X+1, current.GetCords().Y].updateCosts(current.GetCords(), i, cells[current.GetCords().Y, current.GetCords().Y].GetGCost());
                            open.Add(cells[current.GetCords().X+1, current.GetCords().Y]);
                            break;
                        case 2:
                            if (open.Contains(cells[current.GetCords().X, current.GetCords().Y - 1]))
                                open.Remove(cells[current.GetCords().X, current.GetCords().Y - 1]);
                            cells[current.GetCords().X, current.GetCords().Y-1].updateCosts(current.GetCords(), i, cells[current.GetCords().Y, current.GetCords().Y].GetGCost());
                            open.Add(cells[current.GetCords().X, current.GetCords().Y-1]);
                            break;
                        case 3:
                            if (open.Contains(cells[current.GetCords().X-1, current.GetCords().Y]))
                                open.Remove(cells[current.GetCords().X-1, current.GetCords().Y]);
                            cells[current.GetCords().X-1, current.GetCords().Y].updateCosts(current.GetCords(), i, cells[current.GetCords().Y, current.GetCords().Y].GetGCost());
                            open.Add(cells[current.GetCords().X-1, current.GetCords().Y]);
                            break;
                    }
            if (current.GetCords().Equals(end))
            {
                solving = true;
                this.current = end;
                Solve();
                return;
            }

        }

        public void Solve()
        {
            if (!current.Equals(start))
            {
                solvedPath.Add(current);
                current = cells[current.X, current.Y].GetParent();
            }
            else
            {
                solving = false;
                solved = true;
            }
        }
        public bool IsSolved()
        {
            return solved;
        }
        public Point GetStart()
        {
            return start;
        }
        public Point GetEnd()
        {
            return end;
        }

        public bool IsInOpen(Point cell)
        {
            if (open.Find(x => x.GetCords().Equals(cell)) != null)
                return true;
            else
                return false;
        }
        public bool IsInClosed(Point cell)
        {
            if (closed.Find(x => x.GetCords().Equals(cell)) != null)
                return true;
            else
                return false;
        }
        public bool IsInSolved(Point cell)
        {
            if (solvedPath.Contains(cell))
                return true;
            else
                return false;
        }
    }
}
