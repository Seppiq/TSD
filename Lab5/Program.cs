using System;
using System.Collections;

namespace Lab5
{
    class Program
    {
        public static int elementSize = 20;

        static void Main(string[] args)
        {
            int[] array = new int[elementSize];

            Console.WriteLine("Изначальный массив");

            getArray(array);
            foreach (var elements in array)
            {
                Console.Write(" " + elements);
            }

            Console.WriteLine();
            Program program = new Program();
            program.getNonRecursion(array, 0, array.Length - 1);
            foreach (var elements in array)
            {
                Console.Write(" " + elements);
            }

            Console.WriteLine();
            program.quickSortWithRecursion(array, 0, array.Length - 1);
            foreach (var elements in array)
            {
                Console.Write(" " + elements);
            }
        }

        public static void getArray(int[] array)
        {
            Random random = new Random();

            for (int elements = 0; elements < array.Length - 1; elements++)
            {
                array[elements] = random.Next(-50, 50);
            }
        }

        void quickSortWithRecursion(int[] array, int left, int right)
        {
            if (left < right)
            {
                int p = partition(array, left, right);

                quickSortWithRecursion(array, left, p - 1);
                quickSortWithRecursion(array, p + 1, right);
            }
        }

        void getNonRecursion(int[] array, int left, int right)
        {
            
        }

        int partition(int[] array, int left, int right)
        {
            int pivot; // разрешающий элемент
            int l_hold = left; //левая граница
            int r_hold = right; // правая граница
            pivot = array[left];
            while (left < right) // пока границы не сомкнутся
            {
                while ((array[right] >= pivot) && (left < right))
                    right--; // сдвигаем правую границу пока элемент [right] больше [pivot]
                if (left != right) // если границы не сомкнулись
                {
                    array[left] = array[right]; // перемещаем элемент [right] на место разрешающего
                    left++; // сдвигаем левую границу вправо
                }

                while ((array[left] <= pivot) && (left < right))
                    left++; // сдвигаем левую границу пока элемент [left] меньше [pivot]
                if (left != right) // если границы не сомкнулись
                {
                    array[right] = array[left]; // перемещаем элемент [left] на место [right]
                    right--; // сдвигаем правую границу вправо
                }
            }

            (array[left], pivot) = (pivot, left); // ставим разрешающий элемент на место

            return pivot;
        }
    }
}