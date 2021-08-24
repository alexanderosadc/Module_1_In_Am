using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    public class Number7
    {
        private string userText;
        public Number7(string userText)
        {
            this.userText = userText;
        }

        public void TransformToUpperCase()
        {
            string patternStart = "<upcase>";
            string patternEnd = "</upcase>";

            while(userText.Contains(patternStart) || userText.Contains(patternEnd))
            {
                int startIndexPatternStart = userText.IndexOf(patternStart, StringComparison.OrdinalIgnoreCase);
                int startIndexPatternEnd = userText.IndexOf(patternEnd, StringComparison.OrdinalIgnoreCase);
                int lengthOfText = startIndexPatternEnd - (startIndexPatternStart + patternStart.Length);

                string substring = userText.Substring(startIndexPatternStart + patternStart.Length, lengthOfText);
                string upperSubstring = substring.ToUpper();

                userText = userText.Replace(substring, upperSubstring);

                userText = userText.Remove(startIndexPatternEnd, patternEnd.Length);
                userText = userText.Remove(startIndexPatternStart, patternStart.Length);
            }

            Console.WriteLine(userText);
        }
    }
}
