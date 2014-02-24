using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public class Dungeon : Location
    {
        private List<Enemy> enemies;

        public Dungeon(string name)
            : base(name, new Collection<Location>())
        {
            enemies = new List<Enemy>();
        }

        public List<Enemy> Enemies
        {
            get { return enemies; }
        }
    }
}
