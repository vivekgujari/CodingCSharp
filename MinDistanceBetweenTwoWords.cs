using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Coding
{
    public static class MinDistanceBetweenTwoWords
    {
        public static int function(string path, string s1, string s2)
        {
            string file = File.ReadAllText(path).ToLower();
            string[] data = file.Split(new char[] { ' ', '.'}, StringSplitOptions.RemoveEmptyEntries);
            int min = Int32.MaxValue;
            int pos1 = -1;
            int pos2 = -1;
            bool p1 = false;
            bool p2 = false;
            int i = 0;
            while(i < data.Length)
            {
                if (data[i].Equals(s1))
                {
                    pos1 = i;
                    p1 = true;
                }
                if (data[i].Equals(s2))
                {
                    pos2 = i;
                    p2 = true;
                }
                if (Math.Abs(pos1 - pos2) < min/2 && p1 && p2)
                    min = Math.Abs(pos1 - pos2);
                i++;
            }
            return min;
        }
    }
}
