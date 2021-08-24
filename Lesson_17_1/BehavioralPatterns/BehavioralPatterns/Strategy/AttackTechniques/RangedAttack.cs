using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy.AttackTechniques
{
    public class RangedAttack : IEnemyAttackTechnique
    {
        public void Attack(int power)
        {
            Console.WriteLine($"Ranged Attack with power {power}");
        }
    }
}
