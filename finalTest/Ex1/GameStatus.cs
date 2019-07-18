using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class GameStatus
    {
        int LivingPoints;
        int currentLevel;
        public GameStatus()
        {
            this.LivingPoints = 50;
            currentLevel = 1;
        }

        public int GetLivingPoints()
        {
            return this.LivingPoints;
        }
        public int GetCurrentLevel()
        {
            return this.currentLevel;
        }

        public void SetLivingPoints(int LivingPoints)
        {
            this.LivingPoints = LivingPoints;
        }

        public void SetCurrentLevel(int CurrentLevel)
        {
            this.currentLevel = CurrentLevel;
        }
    }
}
