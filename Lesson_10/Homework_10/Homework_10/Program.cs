using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_10
{
    class Program
    {
        public delegate bool Swap(int firstElementIndex, int secondElementIndex);
        public delegate int? IndexOf(string value);
        public delegate void AnonymSwap(int firstElementIndex, int secondElementIndex);
        public delegate int? AnonymIndexOf(string val);

        static void Main(string[] args)
        {
            Console.WriteLine("Delegates");
            EnemyCollection<string> enemies = new EnemyCollection<string>() { };
            enemies[0] = "Alex";
            enemies[1] = "Petr";
            enemies[2] = "Vasile";
            Swap swapValues = enemies.Swap;
            IndexOf valueIndex = enemies.IndexOf;
            
            Console.WriteLine(valueIndex("Alex"));
            swapValues(0, 1);
            Console.WriteLine(valueIndex("Alex"));

            Console.WriteLine("Anonymous Functions");

            AnonymSwap anonymSwap = delegate (int firstElementIndex, int secondElementIndex) {
                string aux = enemies[firstElementIndex];
                enemies[firstElementIndex] = enemies[secondElementIndex];
                enemies[secondElementIndex] = aux;
            };
            AnonymIndexOf anonymIndexOf = delegate (string value) {
                for (int i = 0; i < enemies.Length; i++)
                {
                    if (enemies[i] == value)
                    {
                        return i;
                    }
                }
                return null;
            };

            anonymSwap(0, 1);
            int? index = anonymIndexOf("Alex");
            Console.WriteLine(index);

            Console.WriteLine("Lambda Expressions");

            Action<int, int> lambdaSwap = (int firstElementIndex, int secondElementIndex) => {
                string aux = enemies[firstElementIndex];
                enemies[firstElementIndex] = enemies[secondElementIndex];
                enemies[secondElementIndex] = aux;
            };
            Func<string, int?> lambdaIndexOf = (string value) => {
                for (int i = 0; i < enemies.Length; i++)
                {
                    if (enemies[i] == value)
                    {
                        return i;
                    }
                }
                return null;
            };

            lambdaSwap(0, 1);
            Console.WriteLine("Query Syntax");
            List<string> listOfNames = new List<string>{"Alex", "Fedot", "Luca", "Artiom", "Arsen", "Armen" };
            var namesStartedWithAQuery = from element in listOfNames
                                    where element[0] == 'a' || element[0] == 'A'
                                    select element;
            int Age = 23;
            var namesStartedWithAFluent = listOfNames
                .Where(name => name[0] == 'a' || name[0] == 'A')
                .Select(name => new {Name = name, Age});
            var dude = new { Name = "Bob", Age};

            var alex = new {Name = "ALex", Surename = "Osa" };
            
            foreach (var item in namesStartedWithAFluent)
            {
                Console.WriteLine(item);
            }
        }
    }
}
