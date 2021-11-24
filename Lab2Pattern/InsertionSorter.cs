using System;
using System.Diagnostics;

namespace Lab2Pattern
{
    public class InsertionSorter : ISorter
    {
        public void sort(int[] array)
        {
            var sw = Stopwatch.StartNew();
            int zap = 0;
            for (int i = 0; i < array.Length; i++)
            {
                zap++;
                for (int j = i; j > 0 && array[j - 1] > array[j]; j--)
                {
                    (array[j - 1], array[j]) = (array[j], array[j - 1]);
                    zap++;
                    Print(array);
                }
            }
            sw.Stop();
            Console.WriteLine("Время выполнения сорт.вставками" + sw.Elapsed);
            Console.WriteLine("Количество перестановок " + zap);
        }
        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();
        }
    }
}