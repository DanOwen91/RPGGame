using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Engine.Interfaces.Player;
using Engine.Interfaces.GameItems;
using System.Collections.ObjectModel;

namespace Engine.Models
{
    /// <summary>
    /// Character Class
    /// </summary>
    public class Player : NotifyPropertyChangedBase, IPlayer
    {
        /// <summary>
        /// Player's name
        /// </summary>
        private string playerName;

        public string PlayerName
        {
            get { return playerName; }
            set
            {
                playerName = value;
                OnPropertyChanged(nameof(PlayerName));
            }
        }

        /// <summary>
        /// Player's class
        /// </summary>
        private string _class;

        public string Class
        {
            get { return _class; }
            set
            {
                _class = value;
                OnPropertyChanged(nameof(Class));
            }
        }

        /// <summary>
        /// Player's level
        /// </summary>
        private int level;

        public int Level
        {
            get { return level; }
            set
            {
                level = value;
                OnPropertyChanged(nameof(Level));
            }
        }

        /// <summary>
        /// Player's hit points
        /// </summary>
        private int hitPoints;

        public int HitPoints
        {
            get { return hitPoints; }
            set
            {
                hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }

        }

        /// <summary>
        /// Player's gold amount
        /// </summary>
        private int gold;

        public int Gold
        {
            get { return gold; }
            set
            {
                gold = value;
                OnPropertyChanged(nameof(Gold));
            }
        }

        /// <summary>
        /// Player's experience points
        /// </summary>
        private int experiencePoints;

        public int ExperiencePoints
        {
            get { return experiencePoints; }
            set
            {
                experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
            }
        }

        public ObservableCollection<IGameItem> Inventory { get; set; } = new ObservableCollection<IGameItem>();
    }
}
