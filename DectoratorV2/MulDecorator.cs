using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DectoratorV2
{
    public class MulDecorator : FormulaDecoratorBase
    {
        private double mulNumber;
        public MulDecorator(IFormula startNumber, double mulNumber) : base(startNumber)
        {
            this.mulNumber = mulNumber;
        }

        public override string GetFormula()
        {
            return this.startNumber.GetFormula() + " * " + mulNumber.ToString();
        }

        public override double GetResult()
        {
            return (startNumber.GetResult() * mulNumber);
        }
    }
}
