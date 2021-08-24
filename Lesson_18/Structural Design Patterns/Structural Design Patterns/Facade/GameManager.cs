using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns.Facade
{
    class GameManager
    {
        private EnemiesController _enemiesController;
        private LeaderboardController _leaderboardController;
        private PlayerController _playersController;

        public GameManager()
        {
            _enemiesController = new EnemiesController(10);
            _playersController = new PlayerController(12);
            _leaderboardController = new LeaderboardController();
        }

        public void GetTheWinner()
        {
            if(_enemiesController.GetNumberOfEnemiesAlive() > _playersController.GetNumberOfBullets())
            {
                Console.WriteLine("Enemy Wins");
                _leaderboardController.RefreshScore(false);
            }
            else
            {
                Console.WriteLine("Enemy Wins");
                _leaderboardController.RefreshScore(true);
            }
        }
    }
}
