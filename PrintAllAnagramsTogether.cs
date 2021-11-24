using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Coding
{
    public static class PrintAllAnagramsTogether
    {
        public class a
        {
            public string item;
            public int index;
            public a(string item, int index)
            {
                this.item = item;
                this.index = index;
            }
        }

        public class Comparewords : Comparer<a>
        {
            public override int Compare(a x, a y)
            {
                return x.item.CompareTo(y.item);
            }
        }
        public static void function(string[] array)
        {
            string[] aux = new string[array.Length];
            Array.Copy(array, aux, array.Length);
            sort(array);
            List<a> list = new List<a>();
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(new a(array[i], i));
            }
            list.Sort(new Comparewords());
            list.ForEach(item => Console.Write(aux[item.index] + "\t"));
        }

        private static void sort(string[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                char[] item = array[i].ToCharArray();
                Array.Sort(item);
                array[i] = new string(item);
            }
        }

        

    }
}
