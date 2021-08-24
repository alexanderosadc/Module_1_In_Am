using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns.Decorator
{
    public class SmallEnemy : ISmallEnemy
    {
        protected int speed;
        protected int shootDamage;

        public SmallEnemy(int speed, int shootDamage)
        {
            this.speed = speed;
            this.shootDamage = shootDamage;
        }
        public void Run()
        {
            speed = 10;
            Console.WriteLine("Shoot");
        }

        public void Shoot()
        {
            shootDamage = 10;
            Console.WriteLine("Run");
        }

        public int GetAmountOfDamage()
        {
            return shootDamage;
        }
    }
}
