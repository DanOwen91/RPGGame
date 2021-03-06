﻿using Engine.Interfaces.QuestInterfaces;
using System.Collections.ObjectModel;

namespace Engine.Models
{
    /// <summary>
    /// Class to hold location information. Locations are found using x, y co orindate system
    /// </summary>
    public class Location
    {
        /// <summary>
        /// X cordinate
        /// </summary>
        public int XCordinate { get; set; }
        /// <summary>
        /// Y cordinate
        /// </summary>
        public int YCordinate { get; set; }
        /// <summary>
        /// Name of the location we are in
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the location we are in
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Image we wish to display for location
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// Available Quests at this location
        /// </summary>
        public ObservableCollection<IQuest> AvailableQuests { get; set; } = new ObservableCollection<IQuest>();
    }
}
