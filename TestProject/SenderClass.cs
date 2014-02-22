using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject
{
    public delegate void VerbEventHandler(object sender, VerbEventArgs args);


    class SenderClass
    {
        public event VerbEventHandler Verb;

        public void OnVerb(int seconds)
        {
            if (seconds % 2 == 0)
            {
                Verb(this, new VerbEventArgs(true));
            }
            else
            {
                Verb(this, new VerbEventArgs(false));
            }
        }

        public void Run()
        {
            int count = 0;
            while (true)
            {
                if (DateTime.Now.Second % 5 == 0)
                {
                    OnVerb(DateTime.Now.Second);
                }

                //Console.WriteLine(count);
                count++;

                Thread.Sleep(1000);
            }
        }
    }
}
