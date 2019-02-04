using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Interfaces.GameItems
{
    interface IWeapon : IGameItem
    {
        int MinimumDamage { get; set; }
        int MaxDamage { get; set; }
    }
}
