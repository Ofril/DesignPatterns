using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class LoseState : GameState
    {
        public override GameState GetHit(GameStatus status, int points)
        {
            Console.WriteLine("Youv'e got hit but have already lost");

            return new LoseState();
        }

        public override GameState LevelUp(GameStatus status)
        {
            Console.WriteLine("Youv'e leveled up but have already lost");

            return new LoseState();
        }
    }
}
