using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public abstract class GameObject
    {
        private static int idCounter = 1;

        public int ID { get; protected set; }
        public string Name { get; protected set; }

        protected GameObject(string name)
        {
            this.Name = name;
            this.ID = GetID();
        }

        private static int GetID()
        {
            return idCounter++;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
