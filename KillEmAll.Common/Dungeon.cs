using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public class Dungeon : Location
    {
        private bool completed;

        public Dungeon(string name, Collection<Character> characters, Collection<Item> items)
            : base(name, characters, items)
        {
            this.completed = false;
            this.LocationType = LocationType.Dungeon;
        }

        public bool Completed
        {
            get
            {
                return this.completed;
            }
            set
            {
                // TODO: Validation of monster count
                this.completed = value;
            }
        }
    }
}
