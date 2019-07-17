using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class EntertaimentDevice
    {
        protected int Max;
        protected int State;
        protected bool IsOn;

        public EntertaimentDevice(int max, int state, bool isOn)
        {
            Max = max;
            State = state;
            IsOn = isOn;
        }

        public abstract void PrintState();
        public abstract void PressNext();
        public abstract void PressPrevious();
        public void TurnOn()
        {
            this.IsOn = true;
        }

        public void TurnOff()
        {
            this.IsOn = false;
        }

    }
}
