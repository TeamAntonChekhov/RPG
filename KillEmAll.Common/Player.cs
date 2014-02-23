using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    class Player : Character, IMovable, IFighter
    {
        static Player instance;

        private Player(string name) : base(name)
        {
        }

        public static Player Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Player("Goshko");
                }

                return instance;
            }
        }
    }
}
