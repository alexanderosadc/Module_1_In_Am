using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Homework_6
{
    public class Number6
    {
        private string userText;

        public Number6(string userText)
        {
            this.userText = userText;
        }

        public int FindNumberOfSubstrings(string substring)
        {
            int numberOfSubstrings = 0;
            int lengthOfSubstring = substring.Length;
            while(userText.Contains(substring))
            {
                int startIndex = userText.IndexOf(substring, StringComparison.OrdinalIgnoreCase);
                userText = userText.Remove(startIndex, lengthOfSubstring);
                numberOfSubstrings++;
                Console.WriteLine(userText);
            }
            return numberOfSubstrings;
        }
    }
}
