using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class DropDownMenu : Menu
    {
        public void ShowDropDownMenu()
        {
            Console.WriteLine("Drop Down List");
            List<string> listOfElements =  GetListOfElements();
            ShowElementsOnScreen();
        }
    }
}
