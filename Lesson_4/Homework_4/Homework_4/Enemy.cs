using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4
{
    public class Enemy
    {
        public static readonly string NameOfEnemy;
        private int _weaponPower;
        private int _health;
        static Enemy()
        {
            NameOfEnemy = "Simple Kojima";
            Console.WriteLine("The statit is called only on first call");
        }
        public Enemy(int weaponPower, int health)
        {
            _weaponPower = weaponPower;
            _health = health;
        }

        public int Attack()
        {
            return _weaponPower;
        }

        public void RecieveDamage(int enemWeaponPower)
        {
            _health -= enemWeaponPower;
        }
        public int GetEnemyLife()
        {
            return _health;
        }

        public void ShowEnemyLife()
        {
            Console.WriteLine("Enemy Life =" + _health);
        }

        public void ShowEnemyWeapon()
        {
            Console.WriteLine("Enemy Weapon =" + _health);
        }
    }
}
