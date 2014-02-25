using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillEmAll.Common;

namespace KillEmAll.ConsoleUI
{
    static class ConsoleRenderer
    {
        private static ScreenSymbol[,] screenBuffer;

        static ConsoleRenderer()
        {
            screenBuffer = new ScreenSymbol[Settings.ConsoleHeight, Settings.ConsoleWidth];
        }

        public static void AddTextOnPostion(int row, int col, string text, ConsoleColor textColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            // TODO: validate posX and posY
            for (int i = 0; i < text.Length; i++)
            {
                screenBuffer[row, col] = new ScreenSymbol(text[i], textColor, backgroundColor);

                col++;
            }
        }

        public static void DrawTextOnPostion(int row, int col, string text, ConsoleColor textColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black) 
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void ClearConsoleBuffer()
        {
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }
        }

        /// <summary>
        /// ╔════════════════════╗
        /// ║ asldjasldjalskjd l ║
        /// ╠════════════════════╣
        /// ║ asldjasldjalskjd l ║
        /// ╚════════════════════╝
        /// </summary>

        public static void RenderAll()
        {
            for (int row = 0; row < screenBuffer.GetLength(0); row++)
            {
                for (int col = 0; col < screenBuffer.GetLength(1); col++)
                {
                    ScreenSymbol currentSymbol = screenBuffer[row, col];
                    Console.ForegroundColor = currentSymbol.ForegroundColor;
                    Console.BackgroundColor = currentSymbol.BackgroundColor;
                    Console.Write(currentSymbol.Symbol);
                }
            }
        }

        public static void ClearAll()
        {
            Array.Clear(screenBuffer, 0, screenBuffer.GetLength(0));
        }


        internal static void TestWrite(object sender, EventArgs e)
        {
            Console.Clear();
            int count = 0;
            Dungeon currentDungeon = (sender as GameManager).CurrentDungeon;
            DrawTextOnPostion(5, 10, string.Format("Name - {0}", currentDungeon.Name));


            foreach (var neighbor in currentDungeon.Exits)
            {
                DrawTextOnPostion(10 + count++, 10, neighbor.ToString());
            }
        }
    }
}
