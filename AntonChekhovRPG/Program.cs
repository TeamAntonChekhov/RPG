using AntonChekhovRPG.ConsoleUI;
using System;

namespace AntonChekhovRPG
{
    class Program
    {
        private static GameState gameState = GameState.MainMenu;

        static void Main()
        {
            Settings.Init();

            while (true)
            {
                switch (gameState)
                {
                    case GameState.MainMenu:
                        gameState = MainMenu.Init();
                        break;

                    case GameState.NewGame:
                        //gameState = 
                        break;

                    case GameState.Exit:
                        return;
                }
            }
        }
    }
}
