using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DectoratorV2
{
    public class AddDecorator : FormulaDecoratorBase
    {
        private double addNumber;
        public AddDecorator(IFormula startNumber, double addNumber) : base(startNumber)
        {
            this.addNumber = addNumber;
        }

        public override string GetFormula()
        {
            return this.startNumber.GetFormula() + " + " + addNumber.ToString();
        }

        public override double GetResult()
        {
            return (startNumber.GetResult() + addNumber);
        }
    }
}
