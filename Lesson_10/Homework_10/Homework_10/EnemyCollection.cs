using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_10
{
    public class EnemyCollection<T>
    {
        private T[] arr = new T[100];

        public int Length { get; set; }
        public T this [int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; Length++; }
        }


       /* public bool Swap(int firstElementIndex, int secondElementIndex)
        {
            if (firstElementIndex < arr.Length && secondElementIndex < arr.Length)
            {
                T aux = arr[firstElementIndex];
                arr[firstElementIndex] = arr[secondElementIndex];
                arr[secondElementIndex] = aux;
                return true;
            }
            return false;
        }

        public int? IndexOf(T valueToSearch)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(valueToSearch))
                {
                    return i;
                }
            }
            // for genereic return type we can use default(T)
            return null;
        }*/

    }
}
