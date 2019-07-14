using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Saguie : Vehicle
    {
        protected string wheelSize;

        public Saguie(string model, float cylinder, string color, int numberOfWheels, string wheelSize) : base(model, cylinder, color, numberOfWheels)
        {
            this.wheelSize = wheelSize;
        }

        public override string ToString()
        {
            return "Saguie " + base.ToString() + $" {wheelSize}";
        }
    }
}
