using BehavioralPatterns.Observer;
using BehavioralPatterns.Strategy;
using BehavioralPatterns.Strategy.AttackTechniques;
using BehavioralPatterns.TemplateMethod;
using System;

namespace BehavioralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Observer
            Player player = new Player(1, 2);
            EnemyAi enemyAI = new EnemyAi(player);
            AlliesAi alliesAi = new AlliesAi(player);
            player.TransformPosition(new Position { X = 4, Y = 1 });

            // Strategy
            EnemyController enemyController = new EnemyController(new MeleAttack());
            enemyController.SetAttackTechnique(new RangedAttack());

            // template Method
            EnemyAttackTechniques kungfu = new KungFu();
            EnemyAttackTechniques karate = new Karate();
        }
    }
}
