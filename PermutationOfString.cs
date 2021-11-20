using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public class PermutationOfString
    {
        public List<string> list;
        public void function(string input)
        {
            list = new List<string>();
            helper(input, list, 0, input.Length - 1);
        }

        public void helper(string input, List<string> list, int left, int right)
        {
            if (left == right)
            {
                list.Add(input);
                return;
            }

            for (int i = left; i <= right; i++)
            {
                input = swap(input, i, left);
                helper(input, list, left + 1, right);
            }
        }

        private static string swap(string input, int i, int left)
        {
            char[] result = input.ToCharArray();
            char temp = result[i];
            result[i] = result[left];
            result[left] = temp;
            return new string(result);

        }
    }
}
