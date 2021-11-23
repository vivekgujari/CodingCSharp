using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public static class Isomorphic
    {
        public static bool function(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            Dictionary<char, char> d = new Dictionary<char, char>();
            int i = 0;
            while (i < str1.Length)
            {
                if (!d.ContainsKey(str1[i]))
                {
                    foreach (var key in d.Keys)
                    {
                        if (d[key] == str2[i])
                            return false;
                    }
                    d.Add(str1[i], str2[i]);
                    i++;
                    continue;
                }
                if (d[str1[i]] != str2[i])
                    return false;
                i++;
            }
            return true;
        }
    }
}
