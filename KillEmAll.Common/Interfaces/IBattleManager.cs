using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillEmAll.Common
{
    public interface IBattleManager
    {
        //  Resolves the output from a battle between two fighters.
        //  The first figher is considered to strike first.
        void ResolveBattle(IFighter first, IFighter second);
    }
}
