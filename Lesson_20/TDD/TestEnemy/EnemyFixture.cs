using Moq;
using NUnit.Framework;
using Structural_Design_Patterns;
using Structural_Design_Patterns.Proxy;

namespace TestEnemy
{
    [TestFixture]
    public class EnemyFixture
    {
        [TestCase(0)]
        [TestCase(100)]
        [TestCase(90)]
        public void DecreasingHealthShouldBeGreaterOrEqualThanZero(int healthPointsToDecrease)
        {
            Enemy enemy = new Enemy();
            enemy.DecreaseHealth(healthPointsToDecrease);
            Assert.GreaterOrEqual(0, enemy.Health);
        }

        [Test]
        public void DamageSholdBeLessOrEqualThanHealth()
        {
            Enemy enemy = new Enemy();

            int attackPower = enemy.Power;

            Assert.LessOrEqual(attackPower, enemy.Health);
        }

        [Test]
        public void SpeedShouldBeGreaterOrEqualThanZero()
        {
            Enemy enemy = new Enemy();

            enemy.Move(20);

            Assert.GreaterOrEqual(enemy.Speed, 0);
        }

        [Test]
        public void NewTest()
        {
            var mockEnemy = new Mock<IEnemy>();
            mockEnemy.Setup(enemy => enemy.DecreaseHealth(It.IsAny<int>())).Returns(0);
            GameManager gameManager = new GameManager(mockEnemy.Object);
            int health = gameManager.DecreaseHealthEnemy(100);
           
            Assert.AreEqual(0, health);
        }
    }
}