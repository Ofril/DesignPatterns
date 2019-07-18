using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class ComputerFactory
    {
        public Computer createComputer(string newComputer)
        {
            switch (newComputer)
            {
                case ("Gaming"):
                    {
                        GameCopmuterBuilder gameComp = new GameCopmuterBuilder();
                        gameComp.BuildComputer();
                        return gameComp.GetComputer();
                    }
                case ("Work"):
                    {
                        WorkComputerBuilder workComputer = new WorkComputerBuilder();
                        workComputer.BuildComputer();
                        return workComputer.GetComputer();
                    }
                case ("Living Room"):
                    {
                        LivingRoomComputerBuilder livingRoomComputer = new LivingRoomComputerBuilder();
                        livingRoomComputer.BuildComputer();
                        return livingRoomComputer.GetComputer();
                    }
                default:
                    throw new Exception("There is no such a computer");
            }
        }
    }
}
