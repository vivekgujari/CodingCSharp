using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public static class PermutationOfStrings
    {
        public static void function(string str, int left, int right)
        { 
            if(left == right)
                Console.WriteLine(str);
            for (int i = left; i <= right; i++)
            {
                swap(str, left, i);
                function(str, left + 1, right);
               // swap(str, left, i);
            }
        }
        public static void swap(string str, int i, int j)
        {
            char[] arr = str.ToCharArray();
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            str = new string(arr);
        }
    }
}
