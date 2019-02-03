using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine.Models
{
    /// <summary>
    /// Character Class
    /// </summary>
    public class Player : INotifyPropertyChanged
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
                OnPropertyChanged("PlayerName");
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
                OnPropertyChanged("Class");
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
                OnPropertyChanged("Level");
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
                OnPropertyChanged("HitPoints");
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
                OnPropertyChanged("Gold");
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
                OnPropertyChanged("ExperiencePoints");
            }
        }
        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Method to invoke property change updates to the event handler
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
