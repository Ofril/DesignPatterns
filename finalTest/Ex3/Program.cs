using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            CarShowStatusProxy myStatusCarProxy = new CarShowStatusProxy();
            Console.WriteLine("Using the actions:");
            myStatusCarProxy.ShowLocation();
            myStatusCarProxy.ShowFuel();
        }
    }
}
