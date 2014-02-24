using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillEmAll.Common
{
    public interface IFighter
    {
        double Health { get; set; }
        double AttackSkill { get; set; }
        double DefenseSkill { get; set; }
        double WeaponStrength { get; set; }
        double ArmorStrength { get; set; }
    }
}
