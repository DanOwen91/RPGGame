using Engine.Interfaces.GameItems;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Interfaces.Player
{
    public interface IPlayer
    {
        string PlayerName { get; set; }
        string Class { get; set; }
        int ExperiencePoints { get; set; }
        int Gold{ get; set; }
        int HitPoints { get; set; }
        int Level { get; set; }
        ObservableCollection<IGameItem> Inventory{ get; set; }

    }
}
