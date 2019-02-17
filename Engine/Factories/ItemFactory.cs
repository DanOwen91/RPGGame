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
                new Weapon(new GameItem( 0, "Pointy Stick", 2), 1, 3),
                new Weapon(new GameItem(1, "Rusty Sword", 15), 5, 10),
                new Legs(new GameItem(2, "Leather Legs", 10), 5),
                new Legs(new GameItem(3, "Chain Legs", 20), 10),
                new Torso(new GameItem(4, "Shirt", 10), 5),
                new Torso(new GameItem(5, "Chain Mail", 20), 10),
                new Helmet(new GameItem(6, "Leather Helmet", 10), 5),
                new Helmet(new GameItem(7, "Chain Helmet", 20), 10),

                new Weapon(new GameItem(99, "Magic Hammer", 650), 65, 90)
            };
        }
        public IGameItem CreateGameItem(int ItemId)
        {
            return _gameItems.FirstOrDefault(x => x.ItemId == ItemId);
        }
    }
}
