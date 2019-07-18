using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doing some legs exercise: ");
            PracticeMethodTemplateBase legsPractice = new PracticeLegs();
            legsPractice.Execute();
            Console.WriteLine();

            Console.WriteLine("Doing some shoulders exercise: ");
            PracticeMethodTemplateBase shouldersPractice = new PracticeShoulders();
            shouldersPractice.Execute();
            Console.WriteLine();

            Console.WriteLine("Doing some chest exercise: ");
            PracticeMethodTemplateBase chestPractice = new PracticeChest();
            chestPractice.Execute();
            Console.WriteLine();
        }
    }
}
