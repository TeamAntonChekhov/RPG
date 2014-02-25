using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    internal static class World
    {
        private static List<Dungeon> dungeons;

        static World()
        {
            dungeons = new List<Dungeon>();
        }

        public static Dungeon Init()
        {
            InitializeDungeons();

            return dungeons[0];
        }

        private static void InitializeDungeons()
        {

            //dungeons.Add(new Dungeon("FirstDungeon"));
            //dungeons.Add(new Dungeon("SecondDungeon"));
            //dungeons.Add(new Dungeon("ThirdDungeon"));


            //dungeons[0].AddNeighbor(dungeons[1], dungeons[2]);
            //dungeons[1].AddNeighbor(dungeons[0], dungeons[2]);
            //dungeons[2].AddNeighbor(dungeons[0], dungeons[1]);
        }

    }
}
