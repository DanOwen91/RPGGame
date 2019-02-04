using Engine.Interfaces.GameItems;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    class ItemFactory
    {
        private List<IGameItem> _gameItems;

        public ItemFactory()
        {
            _gameItems = new List<IGameItem>()
            {
                new Weapon(0, "Pointy Stick", 2, 1, 3),
                new Weapon(1, "Rusty Sword", 15, 5, 10),
                new Weapon(99, "Magic Hammer", 650, 65, 90)
            };
        }
        public IGameItem CreateGameItem(int ItemId)
        {
            return _gameItems.FirstOrDefault(x => x.ItemId == ItemId);
        }
    }
}
