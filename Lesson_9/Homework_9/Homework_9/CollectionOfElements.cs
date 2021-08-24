using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework_9
{
    public class CollectionOfElements<T>
    {
        private T[] arr = new T[100];

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
            

        }
        public bool Swap(int firstElementIndex, int secondElementIndex)
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
                if(arr[i].Equals(valueToSearch))
                {
                    return i;
                }
            }
            // for genereic return type we can use default(T)
            return null;
        }
    }
}
