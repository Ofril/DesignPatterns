using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class GameContext
    {
        public GameState gameState;
        public GameStatus gameStatus;
        public GameContext()
        {
            this.gameState = new NewState();
            this.gameStatus = new GameStatus();
        }

        public void gotHit(int points)
        {
            this.gameState = this.gameState.GetHit(this.gameStatus, points);
        }

        public void LevelUp()
        {
            this.gameState = this.gameState.LevelUp(this.gameStatus);
        }

    }
}
