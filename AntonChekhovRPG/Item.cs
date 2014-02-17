using AntonChekhovRPG.Enumerations;
using AntonChekhovRPG.Interfaces;
using System;

namespace AntonChekhovRPG
{
    abstract class Item : IItem
    {
        public ItemType Type
        {
            get;
            private set;
        }

        public string Name
        {
            get
            {
                return this.Type.ToString();
            }
        }

        public string Description
        {
            get
            {
                return this.Type.ToString();
            }
        }
    }
}
