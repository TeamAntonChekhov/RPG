using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public abstract class Enemy : Character, IFighter
    {
        public Enemy(string name, int level)
            : base(name, level)
        {

        }

        public virtual void Attack(IFighter victum)
        {
            throw new NotImplementedException();
        }

        public bool TakeHit(double damage)
        {
            double damageTaken = damage - this.armor;

            if (damageTaken > 0)
            {
                this.health -= damageTaken;

                if (this.health <= 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
