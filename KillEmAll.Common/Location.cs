using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public abstract class Location : GameObject, INeighbor
    {
        private Collection<INeighbor> neighbors;

        protected Location(string name, Collection<INeighbor> neighbors) 
            : base(name)
        {
            this.Neighbors = neighbors;
        }

        public Collection<INeighbor> Neighbors
        {
            get
            {
                return new Collection<INeighbor>(this.neighbors);
            }
            protected set
            {
                this.neighbors = value;
            }
        }

        public void AddNeighbor(params INeighbor[] locations)
        {
            foreach (var location in locations)
            {
                this.neighbors.Add(location);
            }
        }

        public void RemoveNeighbor(params INeighbor[] locations)
        {
            throw new NotImplementedException();
        }
    }
}
