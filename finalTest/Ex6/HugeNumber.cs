using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    public class HugeNumber
    {
        public int num;
        public int power;

        public HugeNumber(int num, int power)
        {
            this.num = num;
            this.power = power;
        }

        public double GetResult()
        {
            return Math.Pow(Convert.ToDouble(num), Convert.ToDouble(power));
        }
    }
}
