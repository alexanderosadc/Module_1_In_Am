using System;
using System.Collections.Generic;
using System.Text;
using InversionOfControl.Entities;

namespace InversionOfControl
{
    public class GameManager : IGameManager
    {
        private IPlayer _player;
        private IEnemy _enemy;

        public GameManager(IPlayer player, IEnemy enemy)
        {
            _player = player;
            _player.SetHealth(10);
            _enemy = enemy;
            _enemy.SetHealth(12);
        }
        public void ComparePlayerAndEnemyHealths()
        {
            if (_player.GetAmountOfHealth() > _enemy.GetAmountOfHealth())
            {
                Console.WriteLine($"Player has more health than enemy");
            }
            else if (_player.GetAmountOfHealth() < _enemy.GetAmountOfHealth())
            {
                Console.WriteLine($"Enemy has more health than player");
            }
            else
            {
                Console.WriteLine($"Enemy has equal health with player");
            }
        }
    }
}
