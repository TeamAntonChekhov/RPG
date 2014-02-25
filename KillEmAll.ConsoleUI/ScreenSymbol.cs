using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillEmAll.ConsoleUI
{
    public struct ScreenSymbol
    {
        public char Symbol { get; set; }
        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }

        /// <summary>
        /// Initializes new instance of ScreenSymbol struct identified by ...
        /// </summary>
        /// <param name="symbol">asddas</param>
        /// <param name="foregroundColor"></param>
        /// <param name="backgroundColor"></param>
        public ScreenSymbol(char symbol, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
            : this()
        {
            this.Symbol = symbol;
            this.ForegroundColor = foregroundColor;
            this.BackgroundColor = backgroundColor;
        }
    }
}
