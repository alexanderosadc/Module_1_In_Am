using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Enemy enemyWithWeapon = new Enemy(12);
            enemyWithWeapon.GetAWeapon(null);*/

            GameManager gameManager = new GameManager();
            gameManager.ShowAllEnemies();
            //gameManager.InitalizeListOfEnemies();
            for(int i = 0; i < 10; i++)
            {
                Random random = new Random();
                Enemy enemy = new Enemy((byte)random.Next(100, 200));
                gameManager.AddEnemy(enemy);
            }

            // gameManager.ShowAllEnemies();
            int finalScore = 0;
            StreamWriter streamWriter = null;
            try
            {
                finalScore = gameManager.CalculateFinalScoreOfAllEnemies();
                streamWriter = new StreamWriter(@"Test/Test.txt");
                streamWriter.Write(finalScore);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if(streamWriter != null)
                    streamWriter.Dispose();
            }
            Console.WriteLine(finalScore);

            Console.WriteLine("---------------------------------");
            try
            {
                DivisionByZero(0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
            }

            Console.WriteLine("---------------------------------");

            Debug.WriteLine("Program Finished With Success");
#if DEBUG // DEBUG
            Console.WriteLine("Final Score=" + finalScore);
#endif
        }

        static int DivisionByZero(int parameter)
        {
            var returnValue = 0;
            try
            {
                returnValue = 10 / parameter;
            }
            catch (Exception e)
            {
                throw;
            }
            return returnValue;
        }
    }
}
