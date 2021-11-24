using System;

namespace Lab2Pattern
{
    class InformantForPrint
    {
        public void printArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(" " + element);
            }
            Console.WriteLine();
        }
    }
}