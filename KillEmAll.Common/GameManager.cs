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
        private IBattleManager battleManager;

        public Dungeon CurrentDungeon
        {
            get
            {
                return this.currentDungeon;
            }
            set
            {
                // TODO: Validate neighbor
                // TODO: More validation of dungeon

                this.currentDungeon = value;
            }
        }

        public event EventHandler Render;
        public event EventHandler UserInput;

        public GameManager()
        {
            player = Player.Instance;
            currentDungeon = World.Init();
            battleManager = new NotSoSimpleBattleManager();
        }

        public GameState Run()
        {
            GameState gameState = GameState.NewGame;

            //  battle idea:
            //  1) Check the enemies in the current dungeon.
            //  2) For each enemy resolve a battle with the player using the
            //      battleManager instance variable.
            //      For let's consider the player strikes first.
            //  3) If the player wins he can get the experience points from the enemy
            //      and distribute them among his skills (attach and defence)
            //  4) If the enemy has better equipment (weapon or armor) the player can 
            //      take them after the battle.
            //  5) The player will restore his health with the time.
            //  6) We can added collection of Potions to each dungeon and if the player
            //      gets them after killing the enemies the player will restore the
            //      corresponding amount of health.
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
