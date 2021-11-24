using System;
using System.Diagnostics;
using System.Linq;

namespace Lab5Pattern
{
    class Program
    {
        static int elementSize = 20;

        static void Main()
        {
            var sw = new Stopwatch();
            
            int[] array = new int[elementSize];

            InformantForPrint informant = new InformantForPrint();
            IRecursion nonReqursion = new NonRecursionQuickSorter();
            IRecursion recursion = new RecursionQuickSorter();

            Console.WriteLine("Изначальный массив");
            getArray(array);
            informant.printArray(array);

            Console.WriteLine("\nБез рекурсии(Стек)");
            Sorter sorterNonRecirsion = new Sorter(nonReqursion);
            sw.Start();
            sorterNonRecirsion.getSorter(array, 0, array.Length - 1);
            sorterNonRecirsion.getSorter(array.ToArray(), 0, array.Length - 1);
            sw.Stop();
            informant.printArray(array);
            Console.WriteLine("Без рекурсии(со стеком) "+sw.Elapsed);
            sw.Reset();

            Console.WriteLine("\nС рекурсией"); 
            Sorter sorterRecursion = new Sorter(recursion);
            sw.Start();
            sorterRecursion.getSorter(array, 0, array.Length - 1);
            sw.Stop();
            informant.printArray(array);
            Console.WriteLine("Время выполнения с рекурсией "+sw.Elapsed);
        }

        public static void getArray(int[] array)
        {
            Random random = new Random();

            for (int elements = 0; elements < array.Length - 1; elements++)
            {
                array[elements] = random.Next(-50, 50);
            }
        }
    }
}