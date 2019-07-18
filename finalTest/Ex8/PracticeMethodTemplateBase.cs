using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    public abstract class PracticeMethodTemplateBase : TemplateQueryRunner
    {
        protected override void ChangeClothes()
        {
            Console.WriteLine("Changing my clothes");
        }
        protected override void DrinkWater()
        {
            Console.WriteLine("Drinking some water");
        }
        protected override void TakeShower()
        {
            Console.WriteLine("taking a shower");
        }
    }
}
