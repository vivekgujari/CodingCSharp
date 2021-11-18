using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public static class RepeatingCharContiguous
    {
        public static string function(string input)
        {
            int start = 0;
            int end = 0;
            int max = -1;
            int i = 0;
            while (i < input.Length)
            {
                int j = i;
                while (j < input.Length && input[i] == input[j])
                {
                    j++;
                }
                if (j - i > max)
                {
                    max = j - i;
                    start = i;
                    end = j;
                    i = j;
                    continue;
                }
                i++;          
            }
            return input.Substring(start, end - start);
        }
    }
}
