using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            HamburgerFactory hamburgerFactory = new HamburgerFactory();
            List<Hamburger> menu = new List<Hamburger>();

            menu.Add(hamburgerFactory.CreateHamburger("Veg"));
            menu.Add(hamburgerFactory.CreateHamburger("VegLettuce"));
            menu.Add(hamburgerFactory.CreateHamburger("Cheese"));
            menu.Add(hamburgerFactory.CreateHamburger("CheeseOnion"));

            Console.WriteLine("Welcome to my Hamburger Factory");
            Console.WriteLine("This is the menu:");

            foreach (Hamburger hamb in menu)
            {
                Console.WriteLine(hamb.ToString());
            }
        }
    }
}
