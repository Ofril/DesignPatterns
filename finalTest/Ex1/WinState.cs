using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class WinState : GameState
    {
        public override GameState GetHit(GameStatus status, int points)
        {
            Console.WriteLine("Youv'e got hit but have already won");

            return new WinState();
        }

        public override GameState LevelUp(GameStatus status)
        {
            Console.WriteLine("Youv'e leveled up but have already won");

            return new WinState();
        }
    }
}