using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public class Potion : Item, IUsable
    {
        public Potion(string name)
            : base(name)
        {

        }
    }
}
