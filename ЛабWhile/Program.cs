using System;

namespace ЛабWhile
{
    class Program
    {
        public static void Main()
        {
            int trud = 0;
            Console.Write("x равен ");
            var x = int.Parse(Console.ReadLine());  //x
            trud++;
            Console.Write("\nСтепень максимальная ");
            var n = int.Parse(Console.ReadLine());  //макс степень
            trud++;
            int[] arr = new int[n+1];
            trud += 2;
            int schetchik = n;
            trud++;
            int i = 0;
            double sum = arr[0];
            trud += 3;
            while (i <= arr.Length-1) 
            {
                Console.Write("[Аргумент " +schetchik+ " равен]");
                schetchik--;
                arr[i] = int.Parse(Console.ReadLine());
                sum = sum * x + arr[i];
                i++;
                trud += 8;
            }
            
            Console.WriteLine($"Количество итераций " + i);
            Console.WriteLine($"Сумма равна " + sum);
            Console.WriteLine($"Трудоемкость " + trud);
        }
    }
}