using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public class DistinctSubsequences
    {
        public List<string> function(string input)
        {
            List<string> prev = new List<string>();
            prev.Add("");
            for (int i = 0; i < input.Length; i++)
            {
                List<string> curr = new List<string>();
                // with no curr char
                curr.AddRange(prev);
                int j = 0;
                while (j < prev.Count)
                {
                    curr.Add(prev[j] + input[i].ToString());
                    j++;
                }
                prev = curr;
            }
            return prev;
        }
        
    }
}
