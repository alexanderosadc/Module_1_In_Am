using System;
using System.Threading;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEnemies = 2;
            int weaponPower = 10;
            int health = 10;
            object objectHealth = health;
            health = (int)objectHealth;
            Enemy firstEnemy = new Enemy(weaponPower, health);
            Enemy secondEnemy = new Enemy(5, 5);

            Thread firstThread = new Thread(firstEnemy.ShowEnemyLife);
            firstThread.Start();

            Thread secondThread = new Thread(secondEnemy.ShowEnemyLife);
           
            secondThread.Start();

            GameManager.Battle(firstEnemy, secondEnemy);
            Console.WriteLine(Enemy.NameOfEnemy);
            if(firstEnemy.GetEnemyLife() < 0)
            {
                numberOfEnemies = GameManager.DecreaseNumberOfEnemiesParameterValue(numberOfEnemies);
                GameManager.DecreaseNumberOfEnemiesParameterReference(ref numberOfEnemies);
                //int finalNumberOfEnemies;
                GameManager.DecreaseNumberOfEnemiesParameterOut(numberOfEnemies, out int finalNumberOfEnemies);
                
            }

            try
            {
                var i = 20;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
