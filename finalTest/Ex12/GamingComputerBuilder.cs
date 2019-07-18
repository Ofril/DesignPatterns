using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class GameCopmuterBuilder : ComputerBuilder
    {
        protected override void createEnclosure()
        {
            computer.createEnclosure("Gaming Computer - Enclosure");
        }

        protected override void addMotherboard()
        {
            computer.addMotherboard("Gaming Computer - Motherboard");
        }

        protected override void addProcessor()
        {
            computer.addProcessor("Gaming Computer - processor");
        }

        protected override void addGraphicCard()
        {
            computer.addGraphicCard("Gaming Computer - graphic card");
        }

        protected override void addMemory()
        {
            computer.addMemory("Gaming Computer - memory");
        }

        protected override void runCheck()
        {
            computer.runCheck("Gaming Computer - checked");
        }
    }
}
