using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Observer
{
    public class AlliesAi
    {
        public AlliesAi(Player player)
        {
            player.PlayerPositionChanged += ProtectThePlayer;
        }

        private void ProtectThePlayer(object sender, Position playerPosition)
        {
            Console.WriteLine($"Protecting player at position X = {playerPosition.X}, Y = {playerPosition.Y}");
        }
    }
}
