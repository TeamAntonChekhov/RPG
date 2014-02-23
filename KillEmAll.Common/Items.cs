using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public abstract class Item : GameObject
    {
        protected Item(string name)
            : base(name)
        {

        } 
    }
}
