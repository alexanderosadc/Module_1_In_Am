using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class EnemyController
    {
        private IEnemyAttackTechnique _attackTechnique;

        public EnemyController(IEnemyAttackTechnique enemyAttackTechnique)
        {
            _attackTechnique = enemyAttackTechnique;
        }

        public void SetAttackTechnique(IEnemyAttackTechnique enemyAttackTechnique)
        {
            _attackTechnique = enemyAttackTechnique;
        }
    }
}
