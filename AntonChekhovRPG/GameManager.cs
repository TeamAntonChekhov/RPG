using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonChekhovRPG
{
    class GameManager
    {
        private GameManager instance;

        public GameManager Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }
                return instance;
            }
        }

        private GameManager()
        {

        }

        //public GameState Init()
        //{

        //}
    }
}
