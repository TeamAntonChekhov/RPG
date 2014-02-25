using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public interface IMovable
    {
        void GoTo(Location location);
    }
}
