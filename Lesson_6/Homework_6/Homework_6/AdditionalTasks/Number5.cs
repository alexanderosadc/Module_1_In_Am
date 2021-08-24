using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    public class Number5
    {
        string userText;

        public Number5()
        {
            userText = string.Empty;
        }
        public void IntoduceTextFromConsole()
        {
            userText = Console.ReadLine();
        }

        public string ReverseString()
        {
            string reversedArray;
            char[] characters = userText.ToCharArray();
            Array.Reverse(characters);
            reversedArray = new string(characters);
            return reversedArray;
        }
    }
}
