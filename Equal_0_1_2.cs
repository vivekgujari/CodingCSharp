using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public static class Equal_0_1_2
    {
        public static int function(string str)
        {
            int result = 0;
            int i = 0;
            while (i < str.Length)
            {
                int j = i;
                Dictionary<char, int> d = new Dictionary<char, int>();
                while (j < str.Length)
                {
                    if (!d.ContainsKey(str[j]))
                    {
                        d.Add(str[j], j);
                    }
                    else
                    {
                        i = d[str[j]];
                        break;
                    }
                    if (d.Count == 3)
                    {
                        result += 1;
                        break;
                    }
                    j++;
                }
                i++;
            }
            return result;
        }
    }
}
