using System;

namespace InversionOfControl.Entities
{
    public class Player : IPlayer
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
            _health = health * 2;
        }

        public void Attack()
        {
            Console.WriteLine($"Attack with power {_power}");
        }
    }
}
