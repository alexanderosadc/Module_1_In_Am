using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl.Entities
{
    public interface IEnemy
    {
        public string GetNickName();
        public int GetAmountOfHealth();
        public void SetHealth(int health);
    }
}
