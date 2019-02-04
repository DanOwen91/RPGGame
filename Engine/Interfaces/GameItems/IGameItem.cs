using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Interfaces.GameItems
{
    interface IGameItem
    {
        int ItemId { get; set; }
        string Name { get; set; }
        int Price { get; set; }

    }
}
