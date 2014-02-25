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

           // newGame.Render += ConsoleRenderer.TestWrite;
            newGame.Render += ConsoleRenderer.RenderLocationInfo;

            //newGame.UserInput += ConsoleInput.TestReadInput;
            newGame.UserInput += ConsoleInput.ReadCommand;

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
                        gameState = GameScreen.GameOver();
                        break;
                    case GameState.Help :
                        gameState = Instructions.Help();
                        break;
                    case GameState.Exit:
                        return;
                }
            }
        }
    }
}
