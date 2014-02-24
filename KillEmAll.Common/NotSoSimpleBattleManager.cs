using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillEmAll.Common
{
    public class NotSoSimpleBattleManager : IBattleManager
    {
        public void ResolveBattle(IFighter first, IFighter second)
        {
            while (true)
            {
                Strike(first, second);

                if (second.Health > 0)
                {
                    Strike(second, first);
                }
                else
                {
                    return;
                }

                if (first.Health <= 0)
                {
                    return;
                }
            }
        }

        //  similar to the very simple implementation by try to take into an account
        //  the weapon and the armor
        private void Strike(IFighter attacker, IFighter victim)
        {
            double damage = attacker.AttackSkill / 2 - victim.DefenseSkill / 4;
            damage += (attacker.WeaponStrength + 1 / victim.ArmorStrength + 1);

            victim.Health -= damage;
        }

    }
}
