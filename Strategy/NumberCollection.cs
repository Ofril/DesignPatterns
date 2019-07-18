using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class NumberCollection
    {
        protected List<int> numbers = new List<int>();
        protected ISort sorter;
        private const int NUMBER = 5;

        public NumberCollection(ISort sorter)
        {
            this.sorter = sorter;
        }

        public void Add(int num)
        {
            this.numbers.Add(num);

            if (this.numbers.Count > NUMBER)
            {
                sorter = new QuickSort();
            }

            Sort();
        }

        public void Remove(int num)
        {
            this.numbers.Remove(num);

            if (this.numbers.Count <= NUMBER)
            {
                sorter = new MergeSort();
            }

            Sort();
        }
         
        public void Sort()
        {
            sorter.Sort(numbers);
        }
    }
}
