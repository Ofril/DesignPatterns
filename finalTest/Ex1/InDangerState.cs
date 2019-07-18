using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class InDangerState : GameState
    {
        public override GameState GetHit(GameStatus status, int points)
        {
            int currLivingPoints = status.GetLivingPoints() - points;
            status.SetLivingPoints(currLivingPoints);

            if (currLivingPoints <= 0)
            {
                Console.WriteLine("Your'e out of living points, GAME OVER");

                return new LoseState();
            }
            else
            {
                Console.WriteLine($"You have lost living points - you now have {currLivingPoints}");

                return new InDangerState();
            }
        }

        public override GameState LevelUp(GameStatus status)
        {
            int Level = status.GetCurrentLevel() + 1;
            status.SetCurrentLevel(Level);

            if (Level > 3)
            {
                Console.WriteLine("Youv'e won the game");

                return new WinState();
            }
            else
            {
                Console.WriteLine($"Youv'e leveled up - your level is now {Level}");

                return new InDangerState();
            }
        }
    }
}
