using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameContext contextGameLost = new GameContext();
            contextGameLost.LevelUp();
            contextGameLost.gotHit(17);
            contextGameLost.gotHit(21);
            contextGameLost.gotHit(28);
            contextGameLost.LevelUp();

            GameContext ContextGameWon = new GameContext();
            ContextGameWon.LevelUp();
            ContextGameWon.gotHit(42);
            ContextGameWon.LevelUp();
            ContextGameWon.LevelUp();
            ContextGameWon.gotHit(2);
            ContextGameWon.LevelUp();
            ContextGameWon.gotHit(10);
        }
    }
}
