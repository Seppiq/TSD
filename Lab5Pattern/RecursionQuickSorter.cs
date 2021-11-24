using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Lab5Pattern
{
    public class RecursionQuickSorter: IRecursion
    {
        public void sort(int[] array, int left, int right)
        {
            QuickSortBase quickSortBase = new QuickSortBase();
            if (left < right)
            {
                int p = quickSortBase.partition(array, left, right);
                
                sort(array, left, p - 1);
                sort(array, p + 1, right);
            }
        }  
    }
}