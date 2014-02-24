using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public class Enemy : Character, IFighter
    {
        private double health;
        private double InitialHealth;

        public Enemy(string name)
            : base(name)
        {

        }

        public double Health {
            get
            {
                return this.health;
            }

            set
            {
                //  initialize the initial health on the first assignment
                //  we need it to include it into the Experience calculation
                if (InitialHealth <= 0)
                {
                    this.InitialHealth = value;
                }

                this.health = value;
            }
        }
        
        
        public double AttackSkill { get; set; }
        public double DefenseSkill { get; set; }
        public double WeaponStrength { get; set; }
        public double ArmorStrength { get; set; }

        public double ExperiencePointsGain()
        {
            return (AttackSkill + DefenseSkill)/2 + InitialHealth / 20;
        }

        public override string ToString()
        {
            return string.Format("{0}, Health: {1}, AttackSkill: {2}, DefenseSkill: {3}, WeaponStrength: {4}, ArmorStrength: {5}, ExpGain: {6}", base.ToString(), Health, AttackSkill, DefenseSkill, WeaponStrength, ArmorStrength, ExperiencePointsGain());
        }
    }
}
