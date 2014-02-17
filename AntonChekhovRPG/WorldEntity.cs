using AntonChekhovRPG.Interfaces;
using System;

namespace AntonChekhovRPG
{
    abstract class WorldEntity : IWorldEntity
    {
        private static int ID_COUNTER = 0;

        private int id;

        public string Name
        {
            get;
            private set;
        }

        public string Description
        {
            get;
            private set;
        }

        public int HitPoints
        {
            get;
            set;
        }

        public int ID
        {
            get
            {
                return this.id;
            }
        }

        public WorldEntity(string name, string description, int hitPoints)
        {
            this.id = ID_COUNTER++; // Assign an id and increase the counter
            this.Name = name;
            this.Description = description;
            this.HitPoints = hitPoints;
        }
    }
}
