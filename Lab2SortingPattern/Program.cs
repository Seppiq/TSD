using System;

namespace Lab2SortingPattern
{
    class Program
    {
        static public int elementSize = 20;
        
        public static void Main()
        {
            InformantForPrint informant = new InformantForPrint();
            Random random = new Random();

            int[] array = new int[elementSize];
            random.NextBytes(array);
            
            ISorter sorterShellSorter = new ShellSorter();
            ISorter sorterInsertionSorter = new InsertionSorter();
            ISorter sorterLab22L = new Lab2_2();
            
            Console.WriteLine("Изначальный массив");
            informant.printArray(array);
            
            Sorter sorterShell = new Sorter(sorterShellSorter);
            sorterShell.getSorter(array);
            informant.printArray(array);
            
            Sorter sorterInsert = new Sorter(sorterInsertionSorter);
            sorterInsert.getSorter(array);
            informant.printArray(array);

            Sorter sorterLab22 = new Sorter(sorterLab22L);
            sorterLab22.getSorter(array);
            informant.printArray(array);
        }
    }
}