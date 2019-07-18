using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberCollection collection = new NumberCollection();
            collection.Add(1);
            collection.Add(5);
            collection.Add(4);
            collection.Add(3);
            collection.Add(15);
            collection.Add(12);
            collection.Add(7);
            collection.Remove(7);
            collection.Remove(1);
            collection.Remove(5);
        }
    }
}
