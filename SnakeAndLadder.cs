using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public class SnakeAndLadder
    {
        public int[] Board;
        public int min;
        public int[] visited;

        class entry
        {
            public int position;
            public int distance;
        }
        public SnakeAndLadder()
        {
            this.Board = new int[30];
            this.Board[2] = 21;
            this.Board[4] = 7;
            this.Board[10] = 25;
            this.Board[19] = 28;
            this.Board[26] = 0;
            this.Board[20] = 8;
            this.Board[16] = 3;
            this.Board[18] = 6;
            this.min = Int32.MaxValue;
            visited = new int[30];
            
        }

        public void MinDiceThrownToWin()
        {
            Queue<entry> Q = new Queue<entry>();

            entry e = new entry();
            e.position = 0;
            e.distance = 0;
            Q.Enqueue(e);

            while (Q.Count != 0)
            {
                entry t = Q.Dequeue();
                if (visited[t.position] == 1)
                    continue;

                visited[t.position] = 1;
                for (int i = 1; i <= 6; i++)
                {
                    if (t.position + i >= Board.Length)
                        continue;
                    if (t.position + i == Board.Length - 1)
                    {
                        t.distance++;
                        if (t.distance < this.min)
                            this.min = t.distance;
                    }
                    entry a = new entry();
                    if (Board[t.position + i] == 0)
                        a.position = t.position + i;
                    else
                        a.position = Board[t.position + i];

                    a.distance = t.distance + 1;
                    Q.Enqueue(a);

                    
                }
            }
        }
    }
}
