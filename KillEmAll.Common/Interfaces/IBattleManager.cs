using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillEmAll.Common
{
    public interface IBattleManager
    {
        void ResolveBattle(IFighter first, IFighter second);
    }
}
