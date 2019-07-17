using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RemoteControl
    {
        private EntertaimentDevice device;

        public RemoteControl(EntertaimentDevice entertaimentDevice)
        {
            this.device = entertaimentDevice;
        }

        public EntertaimentDevice GetDevice()
        {
            return this.device;
        }

        public void SetDevice(EntertaimentDevice device)
        {
            this.device = device;
        }

        public void On()
        {
            this.device.TurnOn();
        }

        public void Off()
        {
            this.device.TurnOff();
        }

        public void Next()
        {
            this.device.PressNext();
        }

        public void Previous()
        {
            this.device.PressPrevious();
        }

        public void PrintState()
        {
            this.device.PrintState();
        }
    }
}
