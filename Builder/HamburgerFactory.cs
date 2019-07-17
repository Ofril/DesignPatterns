using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HamburgerFactory
    {
        public Hamburger CreateHamburger(string name)
        {
            switch (name)
            {
                case ("Veg"):
                    {
                        return getHamburger(new VeggHamburgerBuilder());
                    }
                case ("VegLettuce"):
                    {
                        return getHamburger(new VeggHambBuilderLettuce());
                    }
                case ("Cheese"):
                    {
                        return getHamburger(new CheeseHamburgerBuilder());
                    }
                case ("CheeseOnion"):
                    {
                        return getHamburger(new CheeseHamburgerBuilderOnion());
                    }
                default:
                    throw new HamburgerNotReadyException("No Hamburger For You");
            }
        }

        private static Hamburger getHamburger(HamburgerBuilder builder)
        {
            builder.BuildHamburger();
            return builder.GetHamburger();
        }
    }
}
