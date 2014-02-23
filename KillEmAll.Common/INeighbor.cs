using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public interface INeighbor : IGameObject
    {
        void AddNeighbor(params Location[] locations);
        void RemoveNeighbor(params Location[] locations);
    }
}
