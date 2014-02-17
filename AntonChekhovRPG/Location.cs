using System;
using System.Collections.Generic;
using System.Linq;

namespace AntonChekhovRPG
{
    class Location : WorldEntity
    {
        private List<Location> exits = new List<Location>();
        private List<Item> items = new List<Item>();
        private List<Enemy> enemies = new List<Enemy>();

        public bool ContainsExit(Location exit)
        {
            if (this.exits.Contains(exit))
                return true;
            else
                return false;
        }

        public void AddExit(Location exit)
        {
            this.exits.Add(exit);
        }

        public void RemoveExit(Location exit)
        {
            if (this.ContainsExit(exit))
            {
                this.exits.Remove(exit);
            }
        }

        public bool ContainsItem(Item item)
        {
            if (this.items.Contains(item))
                return true;
            else
                return false;
        }

         public void AddItem(Item item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            if (this.ContainsItem(item))
            {
                this.items.Remove(item);
            }
        }

        public bool ContainsEnemy(Enemy enemy)
        {
            if (this.enemies.Contains(enemy))
                return true;
            else
                return false;
        }

        public void RemoveEnemy(Enemy enemy)
        {
            if (this.ContainsEnemy(enemy))
            {
                this.enemies.Remove(enemy);
            }
        }
    }
}
