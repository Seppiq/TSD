using System;

namespace Lab5Pattern
{
    public class QuickSortBase
    {
        public int partition(int[] array, int left, int  right)
        {
            int pivot; // разрешающий элемент
            //левая граница
            // правая граница
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