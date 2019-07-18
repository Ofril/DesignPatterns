using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class LivingRoomComputerBuilder : ComputerBuilder
    {
        protected override void createEnclosure()
        {
            computer.createEnclosure("Living Room computer - Enclosure");
        }

        protected override void addMotherboard()
        {
            computer.addMotherboard("Living Room computer - Motherboard");
        }

        protected override void addProcessor()
        {
            computer.addProcessor("Living Room computer - processor");
        }

        protected override void addGraphicCard()
        {
            computer.addGraphicCard("Living Room computer - graphic card");
        }

        protected override void addMemory()
        {
            computer.addMemory("Living Room computer - memory");
        }

        protected override void runCheck()
        {
            computer.runCheck("Living Room computer - checked");
        }
    }
}
