using Engine.Interfaces.GameItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class QuestItems : IGameItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }


    }
}
