using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public class Enemy : Character, IFighter
    {
        public Enemy(string name)
            : base(name)
        {

        }

        public double Health { get; set; }
        public double AttackSkill { get; set; }
        public double DefenseSkill { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, Health: {1}, AttackSkill: {2}, DefenseSkill: {3}", base.ToString(), Health, AttackSkill, DefenseSkill);
        }
    }
}
