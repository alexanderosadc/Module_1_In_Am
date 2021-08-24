using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns
{
    public class Enemy : IEnemy
    {
        public int Health { get; private set; }
        public int Power { get; private set; }

        public int Speed { get; private set; }

        public Enemy()
        {
            Speed = 0;
            Health = 100;
            Power = 10;
        }

        public int DecreaseHealth(int pointsOfHealth)
        {
            Health -= pointsOfHealth;
            return Health;
        }

        public void Move(int speed)
        {
            Speed += 10;
        }
    }
}
