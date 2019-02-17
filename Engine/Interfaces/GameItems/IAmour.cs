using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Interfaces.GameItems
{
    interface IAmour : IGameItem
    {
        int DefensePoints { get; set; }
    }
}
