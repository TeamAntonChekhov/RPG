using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillEmAll.ConsoleUI
{
    static class ConsoleInput
    {
        public static void TestReadInput(object sender, EventArgs e)
        {
            Console.ReadLine();
        }

        public static void ReadCommand(object sender, EventArgs e)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string command = input[0];
            string argument = input[1];

            //switch (command)
            //{
            //    case enter:
            //    case go:
            //        this.ChangeLocation(argument);
            //        break;
            //    case fight:
            //    case attack:
            //    case pickup:
            //    case drop:
            //    case use:
            //    default:
            //        break;
            //}
        }
    }
}
