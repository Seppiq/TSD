using System;
using System.Diagnostics;
using static System.Console;

namespace Лаб2
{
    class InsertionSort
    {
        void insertSort(byte[] array)
        {
            int trud = 2;
            var sw = Stopwatch.StartNew();
            for (int i = 0; i < array.Length; i++)
            {
                trud += 9;
                for (int j = i; j > 0 && array[j - 1] > array[j]; j--)
                {
                    trud += 7;
                    trud += 3;
                    int tmp = array[j - 1];
                    trud += 6;
                    array[j - 1] = array[j];
                    array[j] = (byte)tmp;
                }
            }
            sw.Stop();
            WriteLine("Время выполнения сорт.вставками" + sw.Elapsed);
            Console.WriteLine("Трудоемкость алгоритма сортировки вставками " + trud);
        }


        void shellSort(byte[] array)
        {
            var sw = Stopwatch.StartNew();
            int trud = 3;
            for (int gap = array.Length/2; gap > 0; gap /= 2)
            {
                trud  += 4;
                for (int i = gap; i < array.Length; i++)
                {
                    trud += 4;
                    int temp = array[i];
                    int j;
                    trud += 6;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        trud += 10;
                        array[j] = array[j - gap];
                    }

                    trud += 1;
                    array[j] = (byte)temp;
                }
            }
            sw.Stop();
            WriteLine("Время выполнения сортировки Шелла" + sw.Elapsed);
            Console.WriteLine("Трудоемкость алгоритма сортировки Шелла" + trud);
        }
        
        
        public static void printArray(byte[] array)
        {
            foreach (var insert in array) Write(insert + " ");
            WriteLine();
        }


        static void Main(string[] args)
        {
            var random = new Random();
            InsertionSort inso = new InsertionSort();

            byte[] array = new byte[20];
            random.NextBytes(array);
            
            Console.WriteLine("Массив до сортировок: ");
            printArray(array);

            Console.WriteLine();
            inso.insertSort(array);
            Console.WriteLine("Массив после сортировки вставками: ");
            printArray(array);

            Console.WriteLine();
            inso.shellSort(array);
            Console.WriteLine("Массив после сортировки Шелла:");
            printArray(array);
        }
    }
}