using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy.AttackTechniques
{
    public class MeleAttack : IEnemyAttackTechnique
    {
        public void Attack(int power)
        {
            Console.WriteLine($"MeleAttack with power {power}");
        }
    }
}
