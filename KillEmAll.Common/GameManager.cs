using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillEmAll.Common
{
    public class GameManager
    {
        private Dungeon currentDungeon;
        private Player player;

        public event EventHandler Render;
        public event EventHandler UserInput;

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
                if (Render != null)
                {
                    this.OnRender();
                }

                // Take action event
                if (UserInput != null)
                {
                    this.OnUserInput();
                }

                if (gameState != GameState.NewGame)
                {
                    return gameState;
                }
            }
        }

        private void OnRender()
        {
            Render(this, new EventArgs());
        }

        private void OnUserInput()
        {
            UserInput(this, new EventArgs());
        }
    }
}
