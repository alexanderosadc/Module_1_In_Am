using System;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Number2 number2 = new Number2(new int[] {1, 1, 2, 3, 2, 2, 2, 1 });
            number2.MaximalSequenceOfConsElements();*/

            /*Number3 number3 = new Number3(new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 });
            number3.MostFrequentlyOcurring();*/

            /*Number4 number4 = new Number4();
            Console.WriteLine("Introduce number of rows");
            int rowsNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce number of columns");
            int columnNumber = int.Parse(Console.ReadLine());
            Random random = new Random();
            number4.SetMatrixSize(columnNumber, rowsNumber);

            for(int i = 0; i < columnNumber; i++)
            {
                for(int j = 0; j < rowsNumber; j++)
                {
                    int randomNumber = random.Next(20);
                    number4.AddElement(randomNumber);
                }
            }

            number4.ShowMatrixOnTheScreen();*/

            /*  Number5 number5 = new Number5();
              Console.WriteLine("Intoduce Text");
              number5.IntoduceTextFromConsole();
              Console.WriteLine(number5.ReverseString());*/

            /* Number6 number6 = new Number6("We are living in a yellow submarine. " +
                 "We don't have anything else. " +
                 "Inside the submarine is very tight. So we are drinking all the day. " +
                 "We will move out of it in 5 days.");
             int numberOfSubstrings = number6.FindNumberOfSubstrings("in");
             Console.WriteLine("Number of Sub Strings: " + numberOfSubstrings);*/

            /* Number7 number7 = new Number7("We are living in a " +
                 "<upcase>yellow submarine</upcase>. " +
                 "We don't have <upcase>anything</upcase> else.");

             number7.TransformToUpperCase();*/

            Console.WriteLine("Introduce Text");
            string userInput = Console.ReadLine();
            Number8 number8 = new Number8(userInput);

        }
    }
}
