namespace LabSet
{
    public class NumericSet
    {
        private int capacity = 10;
        private int[] set;

        public NumericSet()
        {
            
        }

        public NumericSet(int capacity)
        {
            this.capacity = capacity;
        }

        public NumericSet(int[] set)
        {
            this.set = set;
        }
    }
}