using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    abstract class GameState
    {
        public abstract GameState LevelUp(GameStatus status);
        public abstract GameState GetHit(GameStatus status, int points);


    }
}
