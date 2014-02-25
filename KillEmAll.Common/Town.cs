using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

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
