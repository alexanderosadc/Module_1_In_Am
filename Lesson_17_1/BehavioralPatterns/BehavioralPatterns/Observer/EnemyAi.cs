using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Observer
{
    public class EnemyAi
    {
        private Position _position;
        public EnemyAi(Player player)
        {
            _position = new Position() { X = 0, Y = 0 };
            player.PlayerPositionChanged += FollowThePlayer;
        }

        private void FollowThePlayer(object sender, Position playerPosition)
        {
            if(playerPosition.X < 5 || playerPosition.Y < 5)
            {
                ShootAtPlayer(playerPosition);
            }
            _position.X += playerPosition.X;
            _position.Y += playerPosition.Y;
            
        }

        private void ShootAtPlayer(Position position)
        {
            Console.WriteLine($"Shoot in direction {position.X} {position.Y}");
        }
    }
}
