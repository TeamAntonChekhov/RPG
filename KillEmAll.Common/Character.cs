using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public abstract class Character : GameObject
    {
        protected int level;
        protected double health;
        protected double damage;
        protected double armor;

        protected Character(string name, int level)
            : base(name)
        {

            this.level = level;
        } 
    }
}
