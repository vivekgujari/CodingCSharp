using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public static class NextGreaterElement
    {
        public static int[] function(int[] array)
        {
            int[] result = new int[array.Length];
            result[result.Length - 1] = -1;
            Stack<int> data = new Stack<int>();
            int i = array.Length - 2;
            data.Push(array[array.Length - 1]);
            while (i >= 0)
            {
                while (data.Count > 0 && data.Peek() < array[i])
                {
                    int e = data.Pop();
                }
                if (data.Count == 0)
                {
                    result[i] = -1;
                    data.Push(array[i]);
                    i--;
                    continue;
                }
                result[i] = data.Peek();
                data.Push(array[i]);
                i--;
            }
            return result;
        }
    }
}
