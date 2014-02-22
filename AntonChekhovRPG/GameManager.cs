using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonChekhovRPG
{
    class GameManager
    {
        private Dungeon currentDungeon;
        private Player player;

        public GameManager()
        {
            player = Player.Instance;
        }

        public GameState Run()
        {
            GameState gameState = GameState.NewGame;

            while (true)
            {
                // Draw world event

                // Take action event

                if (gameState != GameState.NewGame)
                {
                    return gameState;
                }
            }
        }
    }
}
