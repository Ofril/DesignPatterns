using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DectoratorV2
{
    public class SubDecorator : FormulaDecoratorBase
    {
        private double subNumber;
        public SubDecorator(IFormula startNumber, double subNumber) : base(startNumber)
        {
            this.subNumber = subNumber;
        }

        public override string GetFormula()
        {
            return this.startNumber.GetFormula() + " - " + subNumber.ToString();
        }

        public override double GetResult()
        {
            return (startNumber.GetResult() - subNumber);
        }
    }
}
