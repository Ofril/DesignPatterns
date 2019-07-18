using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            HugeNumber BigNum = HugeNumberFactory.GetHugeNumber("10,12");
            Console.WriteLine(BigNum.GetResult());
            HugeNumber BigNum2 = HugeNumberFactory.GetHugeNumber("4,2");
            Console.WriteLine(BigNum2.GetResult());
            HugeNumber BigNum3 = HugeNumberFactory.GetHugeNumber("3,8");
            Console.WriteLine(BigNum3.GetResult());
            HugeNumber BigNum4 = HugeNumberFactory.GetHugeNumber("10,12");
            Console.WriteLine(BigNum4.GetResult());
        }
    }
}
