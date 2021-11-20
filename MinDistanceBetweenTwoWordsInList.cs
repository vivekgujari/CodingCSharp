using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public static class MinDistanceBetweenTwoWordsInList
    {
        public static int function(List<string> list, string w1, string w2)
        {
            int pos1 = -1;
            int pos2 = -1;
            int i = 0;
            int min = Int32.MaxValue;
            while (i < list.Count)
            {
                if (list[i].Equals(w1))
                {
                    pos1 = i;
                }
                else if (list[i].Equals(w2))
                {
                    pos2 = i; 
                }

                if (Math.Abs(pos1 - pos2) < min && pos1 != -1 && pos2 != -1)
                {
                    min = pos1 - pos2;
                }
                i++;
            }
            if (min == Int32.MaxValue)
                return -1;
            return min;
        }
    }
}
