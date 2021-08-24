using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns.Facade
{
    class EnemiesController
    {
        private int _numberOfEnemies;
        public EnemiesController(int numberOfEnemeies)
        {
            _numberOfEnemies = numberOfEnemeies;
        }

        public int GetNumberOfEnemiesAlive()
        {
            return _numberOfEnemies;
        }
    }
}
