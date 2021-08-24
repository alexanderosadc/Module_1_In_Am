using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns
{
    class EnemyProxy : IEnemy
    {
        private Enemy _enemy;
        public EnemyProxy(Enemy enemy)
        {
            _enemy = enemy;
        }

        public int DecreaseHealth(int pointsOfHealth)
        {
            if(pointsOfHealth > 0)
            {
                _enemy.DecreaseHealth(pointsOfHealth);
                return _enemy.Health;
            }

            return 0;
        }

        public void Move(int speed)
        {
            if(speed > 0)
            {
                _enemy.Move(speed);
            }
        }


    }
}
