using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MergeSort : ISort
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("Merge Sort");
        }
    }
}
