using System;
using System.Collections.Generic;

namespace KillEmAll.Common
{
    public interface IFighter
    {
        void Attack(IFighter victum);
        bool TakeHit(double damage);
    }
}
