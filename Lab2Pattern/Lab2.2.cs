using System;

namespace Lab2Pattern
{
    public class Lab2_2: ISorter
    {
        public void sort(int[] array)
        {
            //int tmp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < 0 && array[j + 1] > 0)
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);    //без введения вр. переменной

                        /*tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;*/
                    }
                }
            }
        }
    }
}