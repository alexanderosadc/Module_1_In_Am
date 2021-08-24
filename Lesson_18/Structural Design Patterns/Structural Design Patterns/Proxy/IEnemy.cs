using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns
{
    public interface IEnemy
    {
        public int DecreaseHealth(int pointsOfHealth);
        public void Move(int speed);
    }
}
