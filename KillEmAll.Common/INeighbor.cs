using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public interface INeighbor : IGameObject
    {
        void AddNeighbor(params INeighbor[] locations);
        void RemoveNeighbor(params INeighbor[] locations);
    }
}
