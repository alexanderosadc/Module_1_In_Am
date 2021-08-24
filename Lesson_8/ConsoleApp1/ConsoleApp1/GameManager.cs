using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    public class GameManager
    {
        private List<Enemy> listOfEnemies;

      /*  public void InitalizeListOfEnemies()
        {
            listOfEnemies = new List<Enemy>();
        }*/
        public void AddEnemy(Enemy enemy)
        {
            try
            {
                listOfEnemies.Add(enemy);
            }
            catch(NullReferenceException ex)
            {
                listOfEnemies = new List<Enemy>();
                Console.WriteLine(ex.Message);
            }
           
        }
        public void ShowAllEnemies()
        {
            if(listOfEnemies == null)
            {
                throw new EnemiesListNotFoundException("Enemy list was not instantiated");
            }
            else
            {
                foreach (var item in listOfEnemies)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public int CalculateFinalScoreOfAllEnemies()
        {
            byte sum = 0;
            List<Exception> exceptions = new List<Exception>();
            for (int i = 0; i < listOfEnemies.Count + 1; i++)
            {
                
                try
                {
                    sum += listOfEnemies[i].GetEnemyPower();
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    /* Console.WriteLine(ex.Message);
                     Console.WriteLine(ex.StackTrace);*/
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    //throw; - control is handled to the parent which called this function. Function will not return a value

                }
                catch (OverflowException ex)
                {
                    
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }

            }
            return sum;
        }
    }
}
