using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns.Decorator
{
    class PowerUpDecorator : EnemyDecorator
    {
        public PowerUpDecorator(ISmallEnemy enemy) : base(enemy)
        { }

        public override int GetAmountOfDamage()
        {
            return 2 * enemy.GetAmountOfDamage();
        }

        public int GetHealthBar()
        {
            return 10;
        }
    }
}
