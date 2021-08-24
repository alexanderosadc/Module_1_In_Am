using System;
using System.Collections.Generic;
using System.Text;

namespace EncodingDisposalAndGC
{
    class Enemy
    {
        public int Health{ get; set; }
        public Enemy(int health)
        {
            Health = health;
        }

        ~Enemy()
        {
            Console.WriteLine("Enemy Is Dead");
        }
    }
}
