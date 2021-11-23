using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public static class LongestCommonPrefix
    {
        public static string function(string[] array)
        {
            /// find the shortest string
            string prefix = "";
            int min = Int32.MaxValue;
            foreach (var word in array)
            {
                if (word.Length < min)
                {
                    prefix = word;
                    min = word.Length;
                }
            }
            StringBuilder result = new StringBuilder();
            foreach (var word in array)
            {
                int i = 0;
                while (i < word.Length && i < prefix.Length && word[i] == prefix[i])
                {
                    result.Append(prefix[i]);
                    i++;
                }
                prefix = result.ToString();
                result.Clear();
            }
            return prefix;
        }
    }
}
