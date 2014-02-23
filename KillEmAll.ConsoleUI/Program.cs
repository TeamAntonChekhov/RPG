using System;
using KillEmAll.Common;

namespace KillEmAll.ConsoleUI
{
    class Program
    {
        private static GameState gameState = GameState.MainMenu;

        static void Main()
        {
            Settings.Init();
            GameManager newGame = new GameManager();

            newGame.Render += ConsoleRenderer.TestWrite;
            newGame.UserInput += ConsoleInput.TestReadInput;


            while (true)
            {
                switch (gameState)
                {
                    case GameState.MainMenu:
                        gameState = MainMenu.Init();
                        break;

                    case GameState.NewGame:
                        gameState = newGame.Run();
                        break;

                    case GameState.GameOver:
                        //gameState = 

                    case GameState.Exit:
                        return;
                }
            }
        }
    }
}
