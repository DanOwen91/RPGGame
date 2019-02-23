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
        public int Quantity {get; set;}

        public QuestItems(IGameItem gameItem, int quantity)
        {
            this.ItemId = gameItem.ItemId;
            this.Price= gameItem.Price;
            this.Name= gameItem.Name;
            this.Quantity = quantity;
        }
    }
}
