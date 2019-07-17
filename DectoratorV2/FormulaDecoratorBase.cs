using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DectoratorV2
{
    public abstract class FormulaDecoratorBase : IFormula
    {
        protected IFormula startNumber;

        public FormulaDecoratorBase(IFormula startNumber)
        {
            this.startNumber = startNumber;
        }

        public abstract string GetFormula();
        public abstract double GetResult();
    }
}
