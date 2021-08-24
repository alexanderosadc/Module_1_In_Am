using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public interface IEnemyAttackTechnique
    {
        public void Attack(int power);
    }
}
