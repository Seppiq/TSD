using System;

namespace NumericSet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testSeta = new[] { 5, 6, 7, 8 };

            NumericSet set = new NumericSet(testSeta);
            
            for (int i = 0; i < set.getSize() - 1; i++)
            {
                Console.WriteLine(" " + set.getIndex(i));
            }
        }
    }
}