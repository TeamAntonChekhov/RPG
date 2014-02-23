using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public abstract class Location : GameObject, INeighbor
    {
        private Collection<Location> neighbors;

        protected Location(string name, Collection<Location> neighbors) 
            : base(name)
        {
            this.Neighbors = neighbors;
        }

        public Collection<Location> Neighbors
        {
            get
            {
                return new Collection<Location>(this.neighbors);
            }
            protected set
            {
                this.neighbors = value;
            }
        }

        public void AddNeighbor(params Location[] locations)
        {
            foreach (var location in locations)
            {
                this.neighbors.Add(location);
            }
        }

        public void RemoveNeighbor(params Location[] locations)
        {
            throw new NotImplementedException();
        }
    }
}
