using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public abstract class Enemy : Character, IFighter
    {
        public Enemy(string name)
            : base(name)
        {

        }
    }
}
