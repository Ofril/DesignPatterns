using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DectoratorV2
{
    public class DivDecorator : FormulaDecoratorBase
    {
        private double divNumber;
        public DivDecorator(IFormula startNumber, double divNumber) : base(startNumber)
        {
            this.divNumber = divNumber;
        }

        public override string GetFormula()
        {
            return this.startNumber.GetFormula() + " / " + divNumber.ToString();
        }

        public override double GetResult()
        {
            return (startNumber.GetResult() / divNumber);
        }
    }
}
