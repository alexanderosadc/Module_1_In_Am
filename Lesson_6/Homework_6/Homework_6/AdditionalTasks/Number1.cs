using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    public class Number1
    {
        private int[] indexNumbers;

        public Number1()
        {
            indexNumbers = new int[20];
        }
        
        public void AddElementsToArray()
        {
            for(int i = 0; i < indexNumbers.Length; i++)
            {
                indexNumbers[i] = i * 5;
                Console.WriteLine(indexNumbers[i]);
            }
        }
    }
}
