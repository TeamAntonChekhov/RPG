using System.Collections.Generic;

namespace KillEmAll.Common
{
    public interface IExitable : IGameObject
    {
        IEnumerable<Location> Exits { get; }

        void AddExit(params Location[] locations);

        void RemoveExit(params Location[] locations);
    }
}
