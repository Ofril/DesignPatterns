using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Liquor vodka = new Liquor(95);
            Perfume calvin = new Perfume(300);
            ShopRent shopRent = new ShopRent(4500);

            IVisitor endOfYearVisitor = new EndOfYearTax();
            IVisitor oneShekelSale = new OneShekelSale();

            Console.WriteLine(vodka);
            Console.WriteLine($"vodka after tax = {vodka.Accept(endOfYearVisitor)}");
            Console.WriteLine($"vodka after sale = {vodka.Accept(oneShekelSale)}");
            Console.WriteLine(calvin);
            Console.WriteLine($"calvin after tax = {calvin.Accept(endOfYearVisitor)}");
            Console.WriteLine($"calvin after sale = {calvin.Accept(oneShekelSale)}");
            Console.WriteLine(shopRent);
            Console.WriteLine($"shopRent after tax = {shopRent.Accept(endOfYearVisitor)}");
            Console.WriteLine($"shopRent after sale = {shopRent.Accept(oneShekelSale)}");
        }
    }
}
