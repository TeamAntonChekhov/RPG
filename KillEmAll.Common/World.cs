using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

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

            dungeons.Add(new Dungeon("FirstDungeon", new Collection<Character>(), new Collection<Item>()));
            dungeons.Add(new Dungeon("SecondDungeon", new Collection<Character>(), new Collection<Item>()));
            dungeons.Add(new Dungeon("ThirdDungeon", new Collection<Character>(), new Collection<Item>()));


            dungeons[0].AddExit(dungeons[1], dungeons[2]);
            dungeons[1].AddExit(dungeons[0], dungeons[2]);
            dungeons[2].AddExit(dungeons[0], dungeons[1]);
        }

    }
}
