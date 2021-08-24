using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Observer
{
    public struct Position
    {
        public int Y { get; set; }

        public int X { get; set; }
    }
    public class Player
    {
        private Position _position;

        public Player(int positionX, int positionY)
        {
            _position = new Position() { X = positionX, Y = positionY };
        }

        public event EventHandler<Position> PlayerPositionChanged;

        public void TransformPosition(Position unitsMoved)
        {
            _position.X += unitsMoved.X;
            _position.Y += unitsMoved.Y;
            PlayerPositionChanged?.Invoke(this, _position);
        }
    }
}
