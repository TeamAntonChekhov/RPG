using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public class Player : Character, IMovable, IFighter
    {
        static Player instance;

        public Player(string name) : base(name)
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

        public override string ToString()
        {
            return string.Format("{0}, Health: {1}/{2}, AttackSkill: {3}/{4}, DefenseSkill: {5}/{6}", base.ToString(), Health, MaxHealth, AttackSkill, MaxAttackSkill, DefenseSkill, MaxDefenseSkill);
        }
    }
}
