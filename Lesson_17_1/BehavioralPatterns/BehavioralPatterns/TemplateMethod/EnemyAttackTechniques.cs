using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.TemplateMethod
{
    public abstract class EnemyAttackTechniques
    {
        public void Attack(int power)
        {
            MeleAttack(power);
            Defend(power / 2);
            MeleAttack(power);
        }

        protected abstract void MeleAttack(int power);
        protected abstract void Defend(int power);
    }
}
