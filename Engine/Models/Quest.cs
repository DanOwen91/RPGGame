using Engine.Interfaces.GameItems;
using Engine.Interfaces.QuestInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class Quest : IQuest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardPoints { get; set; }
        public int RewardGold { get; set; }
        public ICollection<IGameItem> RewardItems { get; set; } = new List<IGameItem>();
        public ICollection<IGameItem> QuestItems { get; set; } = new List<IGameItem>();

        public Quest(int id, string name, string description, int rewardPoints, int rewardGold, List<IGameItem> rewardGameItems, List<IGameItem> questItems)
        {
            this.Name = name;
            this.Id = id;
            this.Description = description;
            this.RewardGold = rewardGold;
            this.RewardPoints = rewardPoints;
            this.RewardItems = rewardGameItems;
            this.QuestItems = questItems;
        }
    }

}
