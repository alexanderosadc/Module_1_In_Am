using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    public class Number8
    {
        private StringBuilder userText;
        public Number8(string userText)
        {
            this.userText = new StringBuilder();
            this.userText.Append(userText);
            CheckLength();
        }

        public void CheckLength()
        {
            while(userText.Length < 20)
            {
                userText.Append("*");
            }
            Console.WriteLine(userText);
        }
    }
}
