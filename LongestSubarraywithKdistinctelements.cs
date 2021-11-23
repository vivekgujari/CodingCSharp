using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public static class LongestSubarraywithKdistinctelements
    {
        public static int[] function(int[] array, int k)
        {
            int start = -1;
            int end = -1;
            int i = 0;
            int max = Int32.MinValue;
            while (i < array.Length)
            {
                int j = i;
                HashSet<int> set = new HashSet<int>();
                while (j < array.Length)
                {
                    if (!set.Contains(array[j]))
                        set.Add(array[j]);
                    if (set.Count == k)
                    {
                        if (j - i > max)
                        {
                            start = i;
                            end = j;
                            max = j - i;
                        }
                        break;
                    }
                    j++;
                }
                i++;
            }
            List<int> list = new List<int>();
            for (int x = start; x <= end; x++)
                list.Add(array[x]);

            return list.ToArray();
        }
    }
}

