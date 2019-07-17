using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DectoratorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            StartNumber number = new StartNumber(5);
            IFormula numberMul2 = new MulDecorator(number, 2);
            IFormula numberMul2Add100 = new AddDecorator(numberMul2, 100);
            IFormula numberMul2Add100Div12 = new DivDecorator(numberMul2Add100, 12);
            IFormula numberMul2Add100Div12Sub3 = new SubDecorator(numberMul2Add100Div12, 3);
            IFormula numberMul2Add100Div12Sub3Mul4 = new MulDecorator(numberMul2Add100Div12Sub3, 4);
            IFormula numberMul2Add100Div12Sub3Mul4Add7 = new AddDecorator(numberMul2Add100Div12Sub3Mul4, 7);

            Console.WriteLine(numberMul2Add100Div12Sub3Mul4Add7.GetFormula());
            Console.WriteLine(numberMul2Add100Div12Sub3Mul4Add7.GetResult());

            number.modifyNumber(30);

            Console.WriteLine(numberMul2Add100Div12Sub3Mul4Add7.GetFormula());
            Console.WriteLine(numberMul2Add100Div12Sub3Mul4Add7.GetResult());

        }
    }
}
