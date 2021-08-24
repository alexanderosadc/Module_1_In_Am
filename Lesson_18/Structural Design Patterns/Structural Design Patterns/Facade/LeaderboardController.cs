using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns.Facade
{
    class LeaderboardController
    {
        private int _enemyScore;
        private int _playerScore;
        public LeaderboardController()
        {
            _enemyScore = 0;
            _playerScore = 0;
        }

        public void RefreshScore(bool isPlayerWin)
        {
            if(isPlayerWin)
            {
                _playerScore++;
            }
            else
            {
                _enemyScore++;
            }
        }
    }
}
