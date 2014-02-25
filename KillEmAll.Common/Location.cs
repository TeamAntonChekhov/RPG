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
        private Collection<Character> characters;
        private Collection<Item> items;
        private LocationType locationType;
        

        protected Location(string name, Collection<Character> characters, Collection<Item> items) 
            : base(name)
        {
            this.Neighbors = new Collection<Location>();
            this.Characters = characters;
            this.Items = items;
        }

        public LocationType LocationType
        {
            get
            {
                return this.locationType;
            }
            protected set
            {
                this.locationType = value;
            }
        }

        public Collection<Item> Items
        {
            get
            {
                return new Collection<Item>(items);
            }
            protected set
            {
                this.items = value;
            }
        }

        public Collection<Character> Characters
        {
            get
            {
                return new Collection<Character>(characters);
            }
            protected set
            {
                this.characters = value;
            }
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
