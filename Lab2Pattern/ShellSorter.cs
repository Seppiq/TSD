using System;
using System.Diagnostics;

namespace Lab2Pattern
{
    public class ShellSorter : ISorter
    {
        public void sort(int[] array)
        {
            var sw = Stopwatch.StartNew();
            int counter = 4;
            for (int step = array.Length / 2; step > 0; step /= 2) {
                counter++;
                for (int i = step; i < array.Length; i++) {
                    counter++;
                    for (int j = i - step; j >= 0 && array[j] > array[j + step] ; j -= step) {
                        (array[j], array[j + step]) = (array[j + step], array[j]);
                        counter++;
                        Print(array);
                    }
                }
            }
            sw.Stop();
            Console.WriteLine("Время выполнения сортировки Шелла " + sw.Elapsed);
            Console.WriteLine("Количество перестановок " + counter);
        }
        
        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\t" + arr[i]);
            }
            Console.WriteLine();
        }
    }
}