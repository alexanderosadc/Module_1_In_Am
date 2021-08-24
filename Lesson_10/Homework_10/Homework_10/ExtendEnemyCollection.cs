using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_10
{
    public static class ExtendEnemyCollection
    {
        public static bool Swap(this EnemyCollection<string> enemyCollection, int firstElementIndex, int secondElementIndex)
        {
            if (firstElementIndex < enemyCollection.Length && secondElementIndex < enemyCollection.Length)
                {
                string aux = enemyCollection[firstElementIndex];
                enemyCollection[firstElementIndex] = enemyCollection[secondElementIndex];
                enemyCollection[secondElementIndex] = aux;
                return true;
            }
            return false;
        }

        public static int? IndexOf(this EnemyCollection<string> enemyCollection, string valueToSearch)
        {
            for (int i = 0; i < enemyCollection.Length; i++)
            {
                if (enemyCollection[i].Equals(valueToSearch))
                {
                    return i;
                }
            }
            // for genereic return type we can use default(T)
            return null;
        }
    }
}
