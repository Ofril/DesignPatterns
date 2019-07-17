using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DectoratorV2
{
    public class StartNumber : IFormula
    {
        public double number { get; set; }

        public StartNumber(double number)
        {
            this.number = number;
        }

        public string GetFormula()
        {
            return number.ToString();
        }

        public double GetResult()
        {
            return number;
        }

        public void modifyNumber(double number)
        {
            this.number = number;
        }
    }
}
