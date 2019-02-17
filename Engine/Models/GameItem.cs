using Engine.Interfaces.GameItems;

namespace Engine.Models
{
    public class GameItem : IGameItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public GameItem(int itemId, string name, int price)
        {
            this.ItemId = itemId;
            this.Name = name;
            this.Price = price;
        }
    }
}
