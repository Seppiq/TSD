using System;

namespace methods
{
    class Program
    {
        public static void Main()
        {
            Console.Write("x равен ");
            var x = int.Parse(Console.ReadLine());  //x
            
            Console.Write("\nСтепень максимальная ");
            var n = int.Parse(Console.ReadLine());  //макс степень
            
            int[] arr = new int[n+1];
            
            double sum = 0;

            //for (int i = 0; i <= n; i++)
            //for (int i = n; i >= 0; i--)
            
            ForInsertArray(n, arr);
            ForReverseArray(arr, sum, x, n);
            Console.WriteLine($"Сумма равна " + sum);
        }

        public static void ForInsertArray(int n, int[] arr)
        {
            int schetchik = 0;
            
            for (int i = n; i >= 0; i--)
            {
                Console.Write("[Аргумент " + schetchik + " равен]");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        
        public static void ForReverseArray(int[] arr, double sum, int x, int n)
        {
            for (int i = n; i >= 0; i--)
            {
                sum = sum * x + arr[n-i];
            }
        }
    }
}