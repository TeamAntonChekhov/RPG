using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonChekhovRPG.Interfaces
{
    interface IWorldEntity
    {
        string Name { get; private set; }
        string Description { get; private set; }
        int HitPoints { get; private set; }
    }
}
