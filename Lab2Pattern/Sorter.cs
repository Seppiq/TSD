namespace Lab2Pattern
{
    public class Sorter
    {
        private ISorter _sorter;

        public Sorter(ISorter sorter)
        {
            _sorter = sorter;
        }

        public void getSorter(int[] array)
        {
            _sorter.sort(array);
        }
    }
}