using KillEmAll.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KillEmAll.ConsoleUI
{
    static class MainMenu
    {
        private static KeyValuePair<String, GameState>[] menuItems = 
        {
            new KeyValuePair<String, GameState>("New Game", GameState.NewGame),
            new KeyValuePair<String, GameState>("Help", GameState.Help),
            new KeyValuePair<String, GameState>("Exit", GameState.Exit),
        };

        public static GameState Init()
        {
            int selected = 0;
            int topLeftRow = Settings.ConsoleHeight / 3;
            int topLeftCol = Settings.ConsoleWidth / 3;


            while (true)
            {
                // User input
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey();

                    if (pressedKey.Key == ConsoleKey.UpArrow && selected > 0)
                    {
                         selected--;
                    }
                    else if (pressedKey.Key == ConsoleKey.DownArrow && selected < menuItems.Length - 1) 
                    {
                         selected++;
                    }
                    else if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        return menuItems[selected].Value;
                    }
                }
                ConsoleRenderer.ClearConsoleBuffer();

                // Draw menu
                Console.Clear();

                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == selected)
                    {
                        ConsoleRenderer.DrawTextOnPostion(topLeftRow + i * 2, topLeftCol, menuItems[i].Key, ConsoleColor.Red, ConsoleColor.White);
                    }
                    else
                    {
                        ConsoleRenderer.DrawTextOnPostion(topLeftRow + i * 2, topLeftCol, menuItems[i].Key);
                    }
                }

                Thread.Sleep(150);
            }
            
        }
    }
}
