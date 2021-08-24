using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4
{
    //Singleton pattern
    public static class GameManager
    {
        public static void Battle(Enemy firstEnemy, Enemy secondEnemy)
        {
            firstEnemy.RecieveDamage(secondEnemy.Attack());
            secondEnemy.RecieveDamage(firstEnemy.Attack());

            Console.WriteLine("The fight has begun");
        }

        public static int DecreaseNumberOfEnemiesParameterValue(int numberOfEnemies)
        {
            return numberOfEnemies - 1;
        }

        public static void DecreaseNumberOfEnemiesParameterReference(ref int numberOfEnemies)
        {
            numberOfEnemies--;
        }

        public static void DecreaseNumberOfEnemiesParameterOut(int numberOfEnemies, out int finalNumberOfEnemies)
        {
            finalNumberOfEnemies = numberOfEnemies - 1;
        }
    }
}
