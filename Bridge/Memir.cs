using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Memir : EntertaimentDevice
    {
        public Memir(int max, int state, bool isOn) : base(max, state, isOn)
        {
        }

        public override void PressNext()
        {
            Console.WriteLine("Moving to the next channel...");
            State = (State + 1 + Max) % Max;
            PrintState();
        }

        public override void PressPrevious()
        {
            Console.WriteLine("Moving to the previous channel...");
            State = (State - 1 + Max) % Max;
            PrintState();
        }

        public override void PrintState()
        {
            Console.Write("Current channel is: ");
            Console.WriteLine(State);
        }
    }
}
