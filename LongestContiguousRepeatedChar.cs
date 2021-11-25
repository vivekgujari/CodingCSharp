using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public static class LongestContiguousRepeatedChar
    {
        public static string function(string s)
        {
            int start = -1;
            int end = -1;
            int i = 0; /// s = "abbbcc"
            int max = Int32.MinValue;
            while (i < s.Length)
            {
                int j = i;
                while (j < s.Length)
                {
                    if (s[j] == s[i])
                    {
                        if (j - i + 1 > max)
                        {
                            max = j - i + 1;
                            end = j;
                            start = i;
                        }
                    }
                    else
                    {
                        i = j - 1;
                        break;
                    }
                    j++;
                }
                i++;
            }
            return s.Substring(start, end - start + 1);
        }
    }
}
