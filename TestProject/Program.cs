using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        // Subscriber
        static void ConsoleSound_OnVerb(object sender, VerbEventArgs args)
        {
            Console.Beep();
            Console.WriteLine(args.IsEven);
        }

        static void Main(string[] args)
        {

            SenderClass sender = new SenderClass();
            sender.Verb += ConsoleSound_OnVerb;
            sender.Run();
        }
    }
}
