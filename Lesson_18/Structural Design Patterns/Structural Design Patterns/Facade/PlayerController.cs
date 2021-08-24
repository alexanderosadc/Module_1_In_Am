using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns.Facade
{
    class PlayerController
    {
        private int _numberOfBullets;
        public PlayerController(int numberOfBullets)
        {
            _numberOfBullets = numberOfBullets;
        }

        public int GetNumberOfBullets()
        {
            return _numberOfBullets;
        }
    }
}
