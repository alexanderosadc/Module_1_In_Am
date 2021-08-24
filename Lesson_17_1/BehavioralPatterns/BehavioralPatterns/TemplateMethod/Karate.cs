using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.TemplateMethod
{
    class Karate : EnemyAttackTechniques
    {
        protected override void Defend(int power)
        {
            Console.WriteLine($"Karate fighters cand defend against power = {power * 5}");
        }

        protected override void MeleAttack(int power)
        {
            Console.WriteLine($"Karate fighters can attack with power = {power * 5}");
        }
    }
}
