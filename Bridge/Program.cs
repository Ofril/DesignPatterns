using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV(100, 2, true);
            Memir memir = new Memir(50, 5, true);

            RemoteControl remoteControl = new RemoteControl(tv);
            remoteControl.PrintState();
            remoteControl.Off();
            remoteControl.On();
            remoteControl.Previous();
            remoteControl.Next();
            remoteControl.Next();
            remoteControl.Next();
            remoteControl.PrintState();
            Console.WriteLine();

            remoteControl.SetDevice(memir);
            remoteControl.PrintState();
            remoteControl.Off();
            remoteControl.On();
            remoteControl.Previous();
            remoteControl.Next();
            remoteControl.Next();
            remoteControl.Next();
            remoteControl.PrintState();
            Console.WriteLine();
        }
    }
}
