using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public class Town : Location
    {

        public Town(string name, Collection<Character> characters, Collection<Item> items)
            : base(name, characters, items)
        {
            this.LocationType = LocationType.Town;
        }
    }
}
