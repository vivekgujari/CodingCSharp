using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public class MinKnightSteps
    {
        public int[,] Board;
        public int min;
        public class Entry
        {
            public int xpos;
            public int ypos;
            public int steps;
            public Entry(int xpos, int ypos, int steps)
            {
                this.xpos = xpos;
                this.ypos = ypos;
                this.steps = steps;
            }
        }

        public MinKnightSteps()
        {
            this.Board = new int[6, 6];
            this.min = Int32.MaxValue;
        }

        public void MinStepsByKnight(int xcurr, int ycurr, int xtarget, int ytarget)
        {
            int[,] visited = new int[Board.GetLength(0), Board.GetLength(1)];
            Entry e = new Entry(xcurr, ycurr, 0);
            Queue<Entry> Q = new Queue<Entry>();
            Q.Enqueue(e);
            while (Q.Count > 0)
            {
                Entry t = Q.Dequeue();
                if (visited[t.xpos, t.ypos] == 1)
                    continue;

                if (t.xpos == xtarget && t.ypos == ytarget)
                {
                    //t.steps++;
                    if (t.steps < min)
                    {
                        min = t.steps;
                        continue;
                    }
                }
                visited[t.xpos, t.ypos] = 1;
                List<Entry> list = GetValidPos(t);
                list.ForEach(item => Q.Enqueue(item));
            }
        }

        public List<Entry> GetValidPos(Entry E)
        {
            List<Entry> output = new List<Entry>();

            if (ValidPos(E.xpos + 1, E.ypos + 2))
                output.Add(new Entry(E.xpos + 1, E.ypos + 2, E.steps + 1));
            if (ValidPos(E.xpos + 1, E.ypos - 2))
                output.Add(new Entry(E.xpos + 1, E.ypos - 2, E.steps + 1));
            if (ValidPos(E.xpos - 1, E.ypos + 2))
                output.Add(new Entry(E.xpos - 1, E.ypos + 2, E.steps + 1));
            if (ValidPos(E.xpos - 1, E.ypos - 2))
                output.Add(new Entry(E.xpos - 1, E.ypos - 2, E.steps + 1));

            if (ValidPos(E.xpos + 2, E.ypos + 1))
                output.Add(new Entry(E.xpos + 2, E.ypos + 1, E.steps + 1));
            if (ValidPos(E.xpos + 2, E.ypos - 1))
                output.Add(new Entry(E.xpos + 2, E.ypos - 1, E.steps + 1));
            if (ValidPos(E.xpos - 2, E.ypos + 1))
                output.Add(new Entry(E.xpos - 2, E.ypos + 1, E.steps + 1));
            if (ValidPos(E.xpos - 2, E.ypos - 1))
                output.Add(new Entry(E.xpos - 2, E.ypos - 1, E.steps + 1));

            return output;

        }

        public bool ValidPos(int x, int y)
        {
            if (x < Board.GetLength(0) && x >= 0 && y < Board.GetLength(1) && y >= 0)
                return true;
            return false;
        }
    }
}
