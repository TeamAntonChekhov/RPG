namespace KillEmAll.ConsoleUI
{
    using System;
    using KillEmAll.Common;

    public static class Instructions
    {
        public const string instructions = "Instructions";

         public static string line = new String('▄', 70);


        public static GameState Help()
        {
            Settings.Init();
            ConsoleRenderer.DrawTextOnPostion(1, 30, instructions);
            ConsoleRenderer.DrawTextOnPostion(2, 0, line);
            return PrintBackButton();
        }

        private static GameState PrintBackButton()
        {
            string backToMenu = "PRESS ESC TO RETURN TO MAIN MENU";
            Console.SetCursorPosition(0, 29);
            Console.Write(backToMenu);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }

                    if (pressedKey.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        return GameState.MainMenu;
                    }

                }
            }
        }
    }
}
