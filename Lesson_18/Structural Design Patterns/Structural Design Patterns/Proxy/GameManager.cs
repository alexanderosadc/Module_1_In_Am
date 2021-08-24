using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns.Proxy
{
    public class GameManager
    {
        private IEnemy _enemy; 
        public GameManager(IEnemy enemy)
        {
            _enemy = enemy;
        }

        public int DecreaseHealthEnemy(int pointsToDecrease)
        {
            return _enemy.DecreaseHealth(pointsToDecrease);
        }
    }
}
