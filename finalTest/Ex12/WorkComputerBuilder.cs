using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class WorkComputerBuilder : ComputerBuilder
    {
        protected override void createEnclosure()
        {
            computer.createEnclosure("Work computer - Enclosure");
        }

        protected override void addMotherboard()
        {
            computer.addMotherboard("Work computer - Motherboard");
        }

        protected override void addProcessor()
        {
            computer.addProcessor("Work computer - processor");
        }

        protected override void addGraphicCard()
        {
            computer.addGraphicCard("Work computer - graphic card");
        }

        protected override void addMemory()
        {
            computer.addMemory("Work computer - memory");
        }

        protected override void runCheck()
        {
            computer.runCheck("Work computer - checked");
        }
    }
}
