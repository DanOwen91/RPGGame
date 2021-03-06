﻿using Engine.Interfaces.GameItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    internal class Weapon : IWeapon
    {
        public int MinimumDamage { get; set; }
        public int MaxDamage { get; set; }
        public int ItemId { get; set; } 
        public string Name { get; set; }
        public int Price { get; set; }

        public Weapon(IGameItem gameItem, int minDamage ,int maxDamage)
        {
            this.MinimumDamage = minDamage;
            this.MaxDamage = MaxDamage;
            this.Name = gameItem.Name;
            this.ItemId = gameItem.ItemId;
            this.Price = gameItem.Price;
        }
    }
}
