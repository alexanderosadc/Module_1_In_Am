using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Structural_Design_Patterns;

namespace TestEnemy.MethodPerFixture
{
    public class DecreaseHealthFixture
    {
        [Test]
        public void MaximumHealthShouldBeLessOrEqualThanOneHundred()
        {
            Enemy enemy = new Enemy();

            int enemyHealth = enemy.Health;

            Assert.LessOrEqual(enemyHealth, 100);
        }

        [Test]
        public void MinimumHealthShouldBeGreaterOrEqualThanZero()
        {
            Enemy enemy = new Enemy();

            int enemyHealth = enemy.Health;

            Assert.GreaterOrEqual(enemyHealth, 0);
        }
    }
}
