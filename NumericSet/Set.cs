using System;
using System.Collections.Generic;

namespace NumericSet
{
    public class NumericSet
    {
        private int capacity = 10;

        private int size = 0;

        private int[] set;

        public NumericSet()
        {
        }

        public NumericSet(int capacity)
        {
            this.capacity = capacity;
            set = new int[capacity];
        }

        public NumericSet(int[] set)
        {
            this.set = set;
            size = set.Length;
        }

        public int[] getSet()
        {
            return set;
        }
        
        HashSet<>

        public int getSize()
        {
            return capacity;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void clear()
        {
            set = new int[] { };
        }

        public int getIndex(int index)
        {
            return set[index];
        }

        public void add(int element)
        {
            int[] resultArray = new int[++size];
            for (int i = 0; i < set.Length - 1; i++)
            {
                resultArray[i] = set[i];
            }

            resultArray[size - 1] = element;
            set = resultArray;
            size = resultArray.Length;
        }

        public void add(int index, int element)
        {
            int[] resultArray = set;
            Array.Copy(resultArray, index, resultArray, index + 1, size - index);
            resultArray[index] = element;
            size++;
        }

        public void removeByIndex(int index)
        {
            set[size - 1] = 0;
            size--;
        }

        public void removeByElement(int element)
        {
            int index = indexOf(element);
            Array.Copy(set, index + 1, set, index, size - index);
            size--;
        }

        public int indexOf(int element)
        {
            for (int i = 0; i < set.Length; i++)
            {
                if (element == set[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}