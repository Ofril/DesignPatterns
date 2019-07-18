using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    public abstract class TemplateQueryRunner
    {
        protected abstract void ChangeClothes();
        protected abstract void DrinkWater();
        protected abstract void ExecuteWork();
        protected abstract void TakeShower();
            
        public void Execute()
        {
            ChangeClothes();
            DrinkWater();
            ExecuteWork();
            DrinkWater();
            TakeShower();
        }
    }
}
