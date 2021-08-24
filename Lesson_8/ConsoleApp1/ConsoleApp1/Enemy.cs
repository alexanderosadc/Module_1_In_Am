using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public sealed class Enemy
    {
        private Weapon weapon;
        private byte enemyPower;

        public Enemy(byte enemyPower)
        {
            this.enemyPower = enemyPower;
        }
        public void GetAWeapon(Weapon weapon)
        {
            if(weapon == null)
            {
                throw new ArgumentNullException("Weapon is not initialized");
            }
            else
            {
                this.weapon = weapon;
            }
        }

        public byte GetEnemyPower()
        {
            return enemyPower;
        }

        public void SetUpEnemyWeaponPower(int enemyPower)
        {
            if(enemyPower > 255)
            {
                // OverflowException????
                throw new OverflowException("The size of an integer is higher than byte size 255");
            }
            else
            {
                this.enemyPower = (byte)enemyPower;
            }
        }
    }
}
