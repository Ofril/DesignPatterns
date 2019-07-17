using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new BasePizza();

            IPizza pizzaWithTomato = new TomatoTopping(pizza);
            IPizza pizzaWithTomatoAndPineapple = new PineaappleTopping(pizzaWithTomato);
            IPizza pizzaWithTomatoAndPineappleAndCorn = new CornTopping(pizzaWithTomatoAndPineapple);
            IPizza pizzaWithTomatoAndPineappleAndCornAndHalf = new HalfPriceTopping(pizzaWithTomatoAndPineappleAndCorn);

            Console.WriteLine(pizzaWithTomatoAndPineappleAndCornAndHalf.GetDetails());
            Console.WriteLine(pizzaWithTomatoAndPineappleAndCornAndHalf.GetPrice());

            IPizza myfavoritePizza = new TomatoTopping(new CheeseTopping(new BasePizza()));

        }
    }
}
