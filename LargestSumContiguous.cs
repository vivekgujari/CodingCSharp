using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public static class LargestSumContiguous
    {
        public static int[] function(int[] array)
        {
            int i = 0;
            int start = -1;
            int end = -1;
            int maxsum = Int32.MinValue;
            while (i < array.Length)
            {
                int j = i;
                int currsum = 0;
                while (j < array.Length)
                {
                    currsum += array[j];
                    if (currsum >= array[j])
                    {
                        if (currsum > maxsum)
                        {
                            maxsum = currsum;
                            start = i;
                            end = j;
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
            List<int> result = new List<int>();
            for (int x = start; x <= end; x++)
                result.Add(array[x]);

            return result.ToArray();
        }
    }
}
