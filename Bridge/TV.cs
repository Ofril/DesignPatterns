using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TV : EntertaimentDevice
    {
        public TV(int max, int state, bool isOn) : base(max, state, isOn)
        {
        }

        public override void PressNext()
        {
            Console.WriteLine("Moving to the next show...");
            State = (State + 1 + Max) % Max;
            PrintState();
        }

        public override void PressPrevious()
        {
            Console.WriteLine("Moving to the previous show...");
            State = (State -1 + Max) % Max;
            PrintState();
        }

        public override void PrintState()
        {
            Console.Write("Current show is: ");
            Console.WriteLine(State);
        }
    }
}
