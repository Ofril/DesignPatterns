using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class VeggHamburgerBuilder : HamburgerBuilder
    {
        protected override void PrepareBun()
        {
            hamburger.PrepareBun("Cheesy flour");
        }

        protected override void PrepareMain()
        {
            hamburger.PrepareMain("loaf with cheese inside");
        }

        protected override void PrepareTopping()
        {
            hamburger.PrepareTopping("Fat cream cheese");
        }

        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Tomato and cucumber");
        }

        protected override void PreparePriceLabel()
        {
            hamburger.PreparePriceLabel("Today sale - 65 ILS");
        }
    }
}
