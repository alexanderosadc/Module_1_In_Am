using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    public class Number2
    {
        private int[] arrayOfNumbers;

        public Number2(int[] arrayOfNumbers)
        {
            this.arrayOfNumbers = arrayOfNumbers;
        }
        public void MaximalSequenceOfConsElements()
        {
            int startIndexOfMaxConsElements = 0;
            int previousNumber = arrayOfNumbers[0];
            int numberOfConsElements = 0;
            int maxNumberOfConsElements = 0;

            for(int i = 1; i < arrayOfNumbers.Length; i++)
            {
                if(previousNumber == arrayOfNumbers[i])
                {
                    numberOfConsElements++;
                   
                    if (numberOfConsElements > maxNumberOfConsElements)
                    {
                        maxNumberOfConsElements = numberOfConsElements;
                        startIndexOfMaxConsElements = i - maxNumberOfConsElements;
                    }
                }
                else
                {
                    numberOfConsElements = 0;
                }
                previousNumber = arrayOfNumbers[i];
            }
            
            if(maxNumberOfConsElements > 0)
            {
                ShowMaximumSequence(startIndexOfMaxConsElements, maxNumberOfConsElements);
            }
            else
            {
                Console.WriteLine("There is no conseqence elemetns in this array");
            }
            
        }

        public void ShowMaximumSequence(int startIndex, int maxNumberOfConsElements)
        {
            for (int i = startIndex; i <= startIndex + maxNumberOfConsElements; i++)
            {
                Console.WriteLine(arrayOfNumbers[i]);
            }
        }
    }
}
