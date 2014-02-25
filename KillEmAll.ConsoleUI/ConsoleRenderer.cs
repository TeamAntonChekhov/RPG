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
            int row = 1;
            Dungeon currentDungeon = (sender as GameManager).CurrentDungeon;

            DrawTextOnPostion(row, 0, string.Format("{0,0} {1,0} {2,0}", new string('═', 25), currentDungeon.Name, new string('═', 68 - (25 + currentDungeon.Name.Length))));
            row++;

            DrawTextOnPostion(row, 0, "Exits:");
            row++;

            foreach (var exit in currentDungeon.Exits)
            {
                DrawTextOnPostion(row + count++, 0, exit.ToString());
            }
            row+=count;

            DrawTextOnPostion(row, 0, "Items:");
            row++;

            foreach (var item in currentDungeon.Items)
            {
                DrawTextOnPostion(row + count++, 0, item.ToString());
            }

            DrawTextOnPostion(row++, 0, "Enemies:");

            //foreach (var monster in currentDungeon.)
            //{
            //    DrawTextOnPostion(row + count++, 0, monster.ToString());
            //}
        }

        internal static void RenderLocationInfo(object sender, EventArgs e)
        {
            Console.Clear();
            Dungeon currentDungeon = (sender as GameManager).CurrentDungeon;

            RenderCurentDungeon(currentDungeon.Name);
            RenderDugeonExits(currentDungeon.Exits);
            RenderDungeonItems(currentDungeon.Items);
            RenderEnemies();
        }

        public static void RenderPlayerInfo(object sender, EventArgs e)
        {
            RenderPlayerInventory();
            RenderPlayerStats();
        }

        private static void RenderPlayerStats()
        {
            throw new NotImplementedException();
        }

        private static void RenderPlayerInventory()
        {
            throw new NotImplementedException();
        }

        private static void RenderCurentDungeon(string currentDungeon)
        {
            Console.WriteLine(string.Format("{0,0} {1,0} {2,0}", new string('═', 25), currentDungeon, new string('═', 68 - (25 + currentDungeon.Length))));
        }

        private static void RenderDungeonItems(IEnumerable<Item> items)
        {
            Console.WriteLine("Items:");

            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void RenderDugeonExits(IEnumerable<Location> exits)
        {
            Console.WriteLine("Exits:");

            foreach (var exit in exits)
            {
                Console.WriteLine(exit.ToString());
            }
        }

        private static void RenderEnemies()
        {

            Console.WriteLine("Monsters:");
        }
    }
}
