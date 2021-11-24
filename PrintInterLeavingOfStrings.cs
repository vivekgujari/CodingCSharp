using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public static class PrintInterLeavingOfStrings
    {
        public static void function(string str1, string str2)
        {
            string result = string.Empty;
            helper(str1, str2, 0, 0, result);
        }

        private static void helper(string str1, string str2, int i, int j, string result)
        {
            if (result.Length == str1.Length + str2.Length)
            {
                Console.WriteLine(result);
                return;
            }

            if (i < str1.Length)
            {
                helper(str1, str2, i+1, j, result + str1[i].ToString());
            }
            if (j < str2.Length)
            {
                helper(str1, str2, i, j+1, result + str2[j].ToString());
            }
        }
    }
}
