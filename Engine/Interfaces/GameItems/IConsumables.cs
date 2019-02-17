using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Interfaces.GameItems
{
    interface IConsumables : IGameItem
    {
        int HealthRegen { get; set; }

    }
}
