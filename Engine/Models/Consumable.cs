using Engine.Interfaces.GameItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class Consumable : IConsumables
    {
        public int HealthRegen { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Consumable(IGameItem gameItem, int HealthRegen)
        {
            this.HealthRegen = HealthRegen;
            this.Name = gameItem.Name;
            this.ItemId = gameItem.ItemId;
            this.Price = gameItem.Price;
        }
    }
}
