using System;
using System.Collections;
using System.Diagnostics;

namespace Lab5Pattern
{
    public class NonRecursionQuickSorter : IRecursion
    {
        public void sort(int[] array, int left, int right)
        {
            QuickSortBase qsb = new QuickSortBase();

            int trud = 0;
            Stack stack = new Stack();

            stack.Push(left);
            stack.Push(right);
            trud += 3;
            while (stack.Count > 0)
            {
                right = (int)stack.Pop();
                left = (int)stack.Pop();
                if (right - left < 1)
                    continue;

                int index = qsb.partition(array, left, right);

                stack.Push(left);
                stack.Push(index - 1);

                stack.Push(index + 1);
                stack.Push(right);
                trud += 13;
            }
            trud += 1;
            Console.WriteLine("trud стек без рекурсии " + trud);
        }
    }
}