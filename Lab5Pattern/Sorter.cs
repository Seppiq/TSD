using System.Security;

namespace Lab5Pattern
{
    public class Sorter
    {
        private IRecursion _recursion;

        public Sorter(IRecursion recursion)
        {
            _recursion = recursion;
        }

        public void getSorter(int[] array, int left, int right)
        {
            _recursion.sort(array, left, right);
        }
    }
}