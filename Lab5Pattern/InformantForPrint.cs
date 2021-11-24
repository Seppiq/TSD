using System;

namespace Lab5Pattern
{
    public class InformantForPrint
    {
        public void printArray(int[] array)
        {
            foreach (var element in array)
            {
                string getArrayToStringOne = String.Join("[ ]", array);

                getArrayToStringOne = element;
                Console.Write(" " + element);
            }
            Console.WriteLine();
        }
    }
}