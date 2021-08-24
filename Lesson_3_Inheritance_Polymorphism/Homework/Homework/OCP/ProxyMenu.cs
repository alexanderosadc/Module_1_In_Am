using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class ProxyMenu
    {
        public void VerifyIfMenuExist(Menu menu)
        {
            if(menu != null)
            {
                menu.AddElement("Vasile");
            }
            else
            {
                Console.WriteLine("The object was not created");
            }
        }

   
    }
}
