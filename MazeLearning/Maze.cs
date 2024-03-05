using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLearning
{
    public struct Cell
    {
        bool[] walls;
        Point cords;
        bool visited;
        bool item;

        public Cell(int x, int y, bool start)
        {
            item = false;
            walls = new bool[] { start, start, start, start };
            cords = new Point(x, y);
            visited = false;
        }
        public void visit()
        {
            visited = true;
        }
        public void InvertWall(int wall)
        {
            walls[wall] = !walls[wall];
        }

        public void RemoveWalls()
        {
            for (int i = 0; i < walls.Length; i++)
                walls[i] = false;
        }

        public bool isVisited()
        {
            return visited;
        }
        public Point getCords()
        {
            return cords;
        }

        public bool[] getWalls()
        {
            return walls;
        }

        public bool isSpecail()
        {
            return item;
        }

        public void MakeSpacial()
        {
            item = true;
        }
    }
    public abstract class Maze
    {
        public static Random rand = new Random();


        protected Cell[,] cells;
        protected Point currentCell;
        protected int width, height;

        private bool finished;
        public Maze(int width, int height, bool start)
        {
            this.width = width;
            this.height = height;
            cells = new Cell[width, height];
            currentCell = new Point(rand.Next(width), rand.Next(height));
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    cells[i, j] = new Cell(i, j, start);
            finished = false;
        }

        protected void Finish()
        {
            finished = true;
        }
        public virtual void IterateMaze() 
        {
            if (finished)
                return;
        }

        
        public Point GetCurrentCell()
        {
            return currentCell;
        }
        

        public Cell[,] getCells()
        {
            return cells;
        }

        public bool isFinished()
        {
            return finished;
        }

        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }

        public void RemoveWall(int x, int y)
        {
            if (x < 0 || y < 0 || x > width-2 || y > height-2)
                return;
            cells[x, y].RemoveWalls();

        }


        public void MakeSpecial(int x, int y)
        {
            cells[x, y].MakeSpacial();
        }
    }
}
