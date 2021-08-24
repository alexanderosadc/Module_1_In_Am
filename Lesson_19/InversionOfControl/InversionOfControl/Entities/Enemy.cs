using System;

namespace InversionOfControl.Entities
{
    public class Enemy : IEnemy
    {
        private int _health;
        private readonly int _power;
        private readonly string _nickName;

        public string GetNickName()
        {
            return _nickName;
        }

        public int GetAmountOfHealth()
        {
            return _health;
        }

        public void SetHealth(int health)
        {
            _health = health;
        }

        public void Attack()
        {
            Console.WriteLine($"Attack with power {_power}");
        }
    }
}
