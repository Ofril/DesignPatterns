using System;

namespace State
{
    public class IAmOff : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("You broke me");
            return new IAmBroken();
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Turning on the light!");
            return new IAmOn();
        }

        public ILightState Fix()
        {
            Console.WriteLine("Im working, you can turn me off");
            return this;
        }
    }
}
