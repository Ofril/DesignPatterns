using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Track : Vehicle
    {
        protected string lightColor;

        public Track(string model, float cylinder, string color, int numberOfWheels, string lightColor) : base(model, cylinder, color, numberOfWheels)
        {
            this.lightColor = lightColor;
        }

        public override string ToString()
        {
            return "Track " + base.ToString() + $" {lightColor}";
        }
    }
}
