using AntonChekhovRPG.UI;
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
                        gameState = MainMenu.Start();
                        break;

                    case GameState.NewGame:
                        break;

                    case GameState.Exit:
                        return;
                }
            }
        }
    }
}
