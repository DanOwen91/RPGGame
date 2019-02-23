using Engine.Interfaces.GameItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Interfaces.QuestInterfaces
{
    public interface IQuest
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int RewardPoints { get; set; }
        int RewardGold { get; set; }
        ICollection<IGameItem> RewardItems {get; set;}
        ICollection<IGameItem> QuestItems { get; set; }

    }
}
