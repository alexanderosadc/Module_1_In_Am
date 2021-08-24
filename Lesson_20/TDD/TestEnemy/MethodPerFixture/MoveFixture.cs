using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Structural_Design_Patterns;

namespace TestEnemy.MethodPerFixture
{
    public class MoveFixture
    {
        [Test]
        public void MinimumSpeedShouldBeGreaterOrEquallThanZero()
        {
            Enemy enemy = new Enemy();

            int speed = enemy.Speed;

            Assert.GreaterOrEqual(speed, 0);
        }
    }
}
