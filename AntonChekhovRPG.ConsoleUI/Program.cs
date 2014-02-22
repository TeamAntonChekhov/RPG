using AntonChekhovRPG.ConsoleUI;
using AntonChekhovRPG;
using System;

namespace AntonChekhovRPG
{
    class Program
    {
        private static GameState gameState = GameState.MainMenu;

        static void Main()
        {
            Settings.Init();
            GameManager newGame = new GameManager();

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
