using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public abstract class Location : GameObject, IExitable
    {
        private HashSet<Location> exits;

        protected Location(string name, IEnumerable<Location> exits) 
            : base(name)
        {
            this.Exits = exits;
        }

        public IEnumerable<Location> Exits
        {
            get
            {
                return new HashSet<Location>(this.exits);
            }
            protected set
            {
                this.exits = new HashSet<Location>(value);
            }
        }

        public void AddExit(params Location[] locations)
        {
            foreach (var location in locations)
            {
                this.exits.Add(location);
            }
        }

        public void RemoveExit(params Location[] locations)
        {
            throw new NotImplementedException();
        }
    }
}
