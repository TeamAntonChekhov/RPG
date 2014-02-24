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

        public double Health { get; set; }
        public double MaxHealth { get; set; }
        public double AttackSkill { get; set; }
        public double MaxAttackSkill { get; set; }
        public double DefenseSkill { get; set; }
        public double MaxDefenseSkill { get; set; }

    }
}
