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
                    instance = new Player("Goshko")
                    {
                        Health = 100,
                        MaxHealth = 100,
                        AttackSkill = 1,
                        MaxAttackSkill = 10,
                        DefenseSkill = 1,
                        MaxDefenseSkill = 10
                    };
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
