using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleApp1
{
    class EnemiesListNotFoundException : Exception
    {
        public EnemiesListNotFoundException()
        {
        }

        public EnemiesListNotFoundException(string message) : base(message)
        {
        }

        public EnemiesListNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
