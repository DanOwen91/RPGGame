using Engine.Interfaces.GameItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class Weapon : GameItem, IWeapon
    {
        public int MinimumDamage { get; set; }
        public int MaxDamage { get; set; }

        public Weapon(int itemId, string name, int price, int minDamage, int maxDamage) : base(itemId, name, price)
        {
            this.MinimumDamage = minDamage;
            this.MaxDamage = MaxDamage;
        }
    }
}
