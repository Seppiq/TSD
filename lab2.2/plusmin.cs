using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using static System.Console;


namespace Лаб2
{
    public class plusmin
    {
        private static readonly int elementsCount = 20;

        static void printSortedArray(int[] array)
        {
            WriteLine();
            foreach (var insert in array) Write(insert + " ");
        }


        static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < 0 && array[j + 1] > 0)
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);    //без введения вр. переменной
                    }
                }
            }
        }


        public static void Main(string[] args)
        {
            Random random = new Random();
            
            int[] array = new int[elementsCount];
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
            }

            Console.Write("Массив до сортировки ");
            printSortedArray(array);
            Sort(array);
            Console.WriteLine();
            Console.Write("Массив после сортировки ");
            printSortedArray(array);
        }
    }
}