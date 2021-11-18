using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public static class Permutation
    {
        public static void function(string str, int left, int right,
            List<string> result)
        {
            if (left == right)
                result.Add(str);
            for (int i = left; i <= right; i++)
            {
                str = swap(str, left, i);
                function(str, left + 1, right, result);
                //str = swap(str, left, i);
            }
        }
        public static string swap(string str, int i, int j)
        {
            char[] arr = str.ToCharArray();
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            return new string(arr);
        }
    }
}
