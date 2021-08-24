using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    public class Number3
    {
        private int[] arrayOfNumbers;

        public Number3(int[] arrayOfNumbers)
        {
            this.arrayOfNumbers = arrayOfNumbers;
        }
        public void MostFrequentlyOcurring()
        {
            int maxNumberOfOccurence = 0;
            int maxOccuredElement = 0;
            List<int> calculatedElements = new List<int>();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                int number = arrayOfNumbers[i];
                int numberOfOccurence = 1;

                if (calculatedElements.Contains(number))
                    continue;

                for(int j = i + 1; j < arrayOfNumbers.Length; j++)
                {
                    if (number == arrayOfNumbers[j])
                    {
                        numberOfOccurence++;
                        if(numberOfOccurence > maxNumberOfOccurence)
                        {
                            maxNumberOfOccurence = numberOfOccurence;
                            maxOccuredElement = number;
                        }
                    }
                }
                calculatedElements.Add(number);
            }

            if (maxNumberOfOccurence > 0)
            {
                Console.WriteLine($"Max Number Of Occurence of the element {maxOccuredElement} was {maxNumberOfOccurence}");
            }
            else
            {
                Console.WriteLine("All elements appears equally");
            }

        }
    }
}
