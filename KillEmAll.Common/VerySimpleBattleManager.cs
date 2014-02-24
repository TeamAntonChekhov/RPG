using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillEmAll.Common
{
    //  Very simple implementation of Battle Manager relying only on 
    //  the current fighters health, attack and defense skills.
    //  The battle continues until one of the fighters health goes below 0.
    public class VerySimpleBattleManager : IBattleManager
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

        //  something like this but not exactly:
        //  http://www.rpgrevolution.com/forums/index.php?showtopic=51217
        private void Strike(IFighter attacker, IFighter victim)
        {
            double damage = attacker.AttackSkill/2 - victim.DefenseSkill/4;
            victim.Health -= damage;
        }
    }
}
