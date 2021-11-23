using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.DataStructures
{
    public class Heaps
    {
        public int[] array;
        public int size;
        public Heaps()
        {
            array = new int[20];
            size = 0;
        }

        
        public void insert(int item)
        {
            if (size == 0)
            {
                array[size++] = item;
                return;
            }

            array[size++] = item;
            int index = size - 1;
            while (array[index] > array[parentidx(index)])
            {
                swap(array, index, parentidx(index));
                index = parentidx(index);
            }
        }

        public int remove()
        {
            int result = array[0];
            array[0] = array[--size];
            int index = 0;
            while (array[index] < array[getleftchildidx(index)] &&
                array[index] < array[getrightchildidx(index)])
            {
                if (array[getrightchildidx(index)] > array[getleftchildidx(index)])
                {
                    swap(array, getrightchildidx(index), index);
                    index = getrightchildidx(index);
                }
                else
                {
                    swap(array, getleftchildidx(index), index);
                    index = getleftchildidx(index);
                }
            }
            return result;
        }
        private int parentidx(int index)
        {
            return (index - 1) / 2;
        }
        private int getleftchildidx(int parentidx)
        {
            return parentidx * 2 + 1;
        }
        private int getrightchildidx(int parentidx)
        {
            return parentidx * 2 + 2;
        }
        private void swap(int[] arrary, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
