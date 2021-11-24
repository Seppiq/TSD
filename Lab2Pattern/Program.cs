using System;
using System.Linq;

namespace Lab2Pattern
{
    public class Program
    {
        private static byte elementSize = 10;

        public static void Main()
        {
            InformantForPrint informant = new InformantForPrint();  //class-object for a print array

            ISorter sorterShellSorter = new ShellSorter();
            ISorter sorterInsertionSorter = new InsertionSorter();
            ISorter sorterLab22L = new Lab2_2();

            Console.WriteLine("Изначальный массив");
            int[] array = new int[elementSize];
            newArrayGeneration(array);
            informant.printArray(array);
            
            while (true)
            {
                Console.WriteLine("Введите алгоритм");
                string enterSorted = Console.ReadLine().ToLower();
                if (enterSorted == "шелл")
                {
                    Sorter sorterShell = new Sorter(sorterShellSorter);
                    sorterShell.getSorter(array.ToArray()); //копия массива
                    informant.printArray(array);
                }
                else if (enterSorted.StartsWith("встав"))
                {
                    Sorter sorterInsert = new Sorter(sorterInsertionSorter);
                    sorterInsert.getSorter(array.ToArray());
                    informant.printArray(array);
                }
                else if (enterSorted.StartsWith("порядок"))
                {
                    Sorter sorterLab22 = new Sorter(sorterLab22L);
                    sorterLab22.getSorter(array.ToArray());
                    informant.printArray(array);
                }
            }
        }

        public static void newArrayGeneration(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
            }
        }
    }
}