using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public abstract class Character : GameObject
    {
        protected Character(string name)
            : base(name)
        {

        } 
    }
}
