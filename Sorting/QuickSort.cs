using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.Sorting
{
    public static class QuickSort
    {
        public static void Sort(int[] array, int left, int right)
        {
            if (left > right)
                return;
            // partition
            int p = partition(array, 0, right);
            // sort left
            Sort(array, left, p - 1);
            // sort right
            Sort(array, p + 1, right);
        }

        public static int partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;
            for (int x = left; x < right; x++)
            {
                if(pivot > array[x])
                {
                    i++;
                    swap(array, i, x);
                }
            }
            i++;
            swap(array, i, right);
            return i;
        }

        public static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
