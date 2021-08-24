using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework_7
{
    interface Car
    {
        void Drive();
    }

    class Toyota : IEnumerable<char>, Car {
        static IEnumerable<char> GetEnum(string name)
        {
            foreach (char character in name)
            {
                yield return character;
            }
        }

        public IEnumerator<char> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void Car.Drive()
        {
            foreach (var item in this)
            {
                
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnum("alex").GetEnumerator();
        }
    }
}
