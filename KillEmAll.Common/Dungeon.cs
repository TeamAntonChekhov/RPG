using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public class Dungeon : Location
    {
        public Dungeon(string name)
            : base(name, new Collection<Location>())
        {
        }
    }
}
