using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.Sorting
{
    public static class MergeSort
    {
        public static void Sort(int[] array)
        {
            if (array.Length == 1)
                return;
            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];
            for (int i = 0; i < mid; i++)
                left[i] = array[i];
            for (int i = mid; i < array.Length; i++)
                right[i - mid] = array[i];
            Sort(left);
            Sort(right);
            Merge(left, right, array);
        }

        private static void Merge(int[] left, int[] right, int[] array)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                    array[k++] = left[i++];
                else
                    array[k++] = right[j++];
            }
            while (i < left.Length)
                array[k++] = left[i++];
            while (j < right.Length)
                array[k++] = right[j++];
        }
    }
}
