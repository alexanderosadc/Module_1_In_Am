using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // LSP
            /*RadioButton radioButton = new RadioButton();
            Button checkboxButton = new CheckBoxButton();

            
            Console.WriteLine(radioButton.GetButtonGroup());
            Console.WriteLine(checkboxButton.GetButtonGroup());*/

            // OCP correct
            ProxyMenu proxyMenu = new ProxyMenu();
            Menu menu = new Menu();
            proxyMenu.VerifyIfMenuExist(menu);
        }
    }
}
