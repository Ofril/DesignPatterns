using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {

            ComputerFactory factory = new ComputerFactory();
            Console.WriteLine("Gaming: " + factory.createComputer("Gaming"));
            Console.WriteLine("Work: " + factory.createComputer("Work"));
            Console.WriteLine("Living Room: " + factory.createComputer("Living Room"));
        }
    }
}
