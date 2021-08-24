using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Menu
    {
        protected List<string> _listOfElements;

        public Menu()
        {
            _listOfElements = new List<string>();
        }
        public void AddElement(string text)
        {
            _listOfElements.Add(text);
        }

        public List<string> GetListOfElements()
        {
            return _listOfElements;
        }

        public void DeleteElement(string text)
        {
            _listOfElements.Remove(text);
        }

        public void ShowElementsOnScreen()
        {
            foreach (string item in _listOfElements)
            {
                Console.Write(item);
            }
        }

    }
}
