using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns.Decorator
{
    abstract class EnemyDecorator : ISmallEnemy
    {
        protected ISmallEnemy enemy;
        protected EnemyDecorator(ISmallEnemy enemy)
        {
            this.enemy = enemy;
        }
        public void SetComponent(ISmallEnemy enemy)
        {
            this.enemy = enemy;
        }

        public abstract int GetAmountOfDamage();
    }
}
