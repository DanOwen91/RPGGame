using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal class PlayerFactory
    {
        internal static Player CreatePlayer(string Class, string playerName)
        {
            ItemFactory itemFactory = new ItemFactory();

            if (Class.ToLower() == "turtle")
            {
                return new Player()
                {
                    PlayerName = playerName,
                    Class = "Turtle",
                    ExperiencePoints = 0,
                    Level = 1,
                    HitPoints = 100,
                    Gold = 100,
                    Inventory = new System.Collections.ObjectModel.ObservableCollection<Interfaces.GameItems.IGameItem>()
                    {
                        itemFactory.CreateGameItem(99),
                        itemFactory.CreateGameItem(2),
                        itemFactory.CreateGameItem(4),
                        itemFactory.CreateGameItem(6)
                    }
                };
            }

            return new Player()
            {
                PlayerName = playerName,
                Class = "Warrior",
                ExperiencePoints = 0,
                Level = 1,
                HitPoints = 120,
                Gold = 70,
                Inventory = new System.Collections.ObjectModel.ObservableCollection<Interfaces.GameItems.IGameItem>()
                    {
                        itemFactory.CreateGameItem(0),
                        itemFactory.CreateGameItem(2),
                        itemFactory.CreateGameItem(4),
                        itemFactory.CreateGameItem(6)
                    }
            };
        }
    }
}
