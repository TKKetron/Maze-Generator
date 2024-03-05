namespace MazeLearning
{
    public class Recursive_Maze : Maze
    {
        public Recursive_Maze(int width, int height) : base(width, height, false)
        {
            foreach (Cell c in cells)
            {
                if (c.getCords().X == 0)
                    c.InvertWall(3);
                if (c.getCords().Y == 0)
                    c.InvertWall(2);
                if (c.getCords().X == width-1)
                    c.InvertWall(1);
                if (c.getCords().Y == height-1)
                    c.InvertWall(0);
            }
        
        }

        public override void IterateMaze()
        {
            if (isFinished())
                return;
            IterateMaze(0, width, 0, height);
            Finish();
        }
        public void IterateMaze(int startX, int endX, int startY, int endY)
        {
            if (startX + 1 >= endX)
                return;
            if (startY + 1 >= endY)
                return;

            int missing;
            int line;

            if (endX - startX >= endY - startY) //draw a vertical line
            {
                missing = rand.Next(startY, endY);
                line = rand.Next(startX, endX-1);
                var x = line - missing - startY - endY;
                for (int i = startY; i < endY; i++)
                {
                    if (i == missing)
                        continue;
                    cells[line, i].InvertWall(1);
                    cells[line + 1, i].InvertWall(3);
                }

                IterateMaze(startX, line+1, startY, endY);
                IterateMaze(line+1, endX, startY, endY);
            }
            else
            {

                //draw a horizontal line
                missing = rand.Next(startX, endX);
                line = rand.Next(startY, endY-1);
                var x = line - missing - startY - endY;
                for (int i = startX; i < endX; i++)
                {
                    if (i == missing)
                        continue;
                    cells[i, line].InvertWall(0);
                    cells[i, line + 1].InvertWall(2);
                }
                IterateMaze(startX, endX, startY, line+1);
                IterateMaze(startX, endX, line+1, endY);
            }
        }

    }
}
