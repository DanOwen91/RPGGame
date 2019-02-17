using Engine.Interfaces.GameItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class Helmet : IAmour
    {
        public int DefensePoints { get; set; }
        public string Name { get; set; }
        public int ItemId { get; set; }
        public int Price { get; set; }

        public Helmet(IGameItem gameItem, int def)
        {
            this.DefensePoints = def;
            this.Name = gameItem.Name;
            this.ItemId = gameItem.ItemId;
            this.Price = gameItem.Price;
        }
    }
}

