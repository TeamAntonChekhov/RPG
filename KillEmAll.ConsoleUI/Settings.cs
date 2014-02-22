using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillEmAll.ConsoleUI
{
    static class Settings
    {
        public const int ConsoleWidth = 70;
        public const int ConsoleHeight = 30;

        public static void Init()
        {
            Console.WindowWidth = ConsoleWidth;
            Console.WindowHeight = ConsoleHeight;
            Console.BufferWidth = ConsoleWidth;
            Console.BufferHeight = ConsoleHeight;
        }
    }
}
