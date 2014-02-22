using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AntonChekhovRPG
{
    class Player
    {
        static Player instance;

        private Player()
        {
        }

        public static Player Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Player();
                }

                return instance;
            }
        }
    }
}
