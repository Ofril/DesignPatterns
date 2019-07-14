using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmBroken : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("I'm broken...");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("I'm broken...");
            return this;
        }

        public ILightState Fix()
        {
            Console.WriteLine("You fixed me!");
            return new IAmOff();
        }
    }
}
