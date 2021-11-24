using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Лаб1
{
    class Program
    {
        public static void forGorner(int n, int[] arr, int x)
        {
            int trud = 0;
            int sum = 0;
            trud += 2;
            
            trud += 2;
            for (int i = n; i >= 0; i--)
            {
                trud += 8;
                sum = sum * x + arr[n-i];
            }
            Console.WriteLine("Сумма цикла For " + sum);
            Console.WriteLine("Трудоемкость For" + trud);
        }

        public static void whileGorner(int n, int[] arr, int x)
        {
            int trud = 0;
            int i = 0;
            int sum = 0;
            trud += 3;

            while (n >= i)
            {
                trud += 8;
                sum = sum * x + arr[i];
                i++;
            }
            trud++;
            Console.WriteLine("Сумма цикла While " + sum);
            Console.WriteLine("Трудоемкость While" + trud);
        }
        
        public static void Main()
        {
            Console.Write("Аргумент х = ");
            int x = int.Parse(Console.ReadLine());  //x
            
            Console.Write("Степень максимальная ");
            int n = int.Parse(Console.ReadLine());  //макс степень

            int[] arr = new int[n+1];

            int schetchik = 0;
            for (int i = n; i >= 0; i--)
            {
                Console.Write("[Коэффициент " + schetchik + " равен]");
                arr[i] = int.Parse(Console.ReadLine());
                schetchik++;
            }

            whileGorner(n, arr, x);
            forGorner(n, arr, x);
        }
    }
}