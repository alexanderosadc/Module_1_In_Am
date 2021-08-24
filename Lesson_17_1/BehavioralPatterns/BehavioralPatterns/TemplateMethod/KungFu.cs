using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.TemplateMethod
{
    public class KungFu : EnemyAttackTechniques
    {
        protected override void Defend(int power)
        {
            Console.WriteLine($"Kung fu fighters cand defend against power = {power * 2}");
        }

        protected override void MeleAttack(int power)
        {
            Console.WriteLine($"Kung fu fighters can attack with power = {power * 2}");
        }
    }
}
