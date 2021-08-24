using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Button
    {
        public void OnButtonClick()
        {
            Console.WriteLine("Button Clicked");
        }
        public void AddText()
        {
            Console.WriteLine("Text Added");
        }
        public virtual string GetButtonGroup()
        {
            return "Name Of Button Group";
        }
    }
}
