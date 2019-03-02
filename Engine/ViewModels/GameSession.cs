using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Factories;
using System.ComponentModel;

namespace Engine.ViewModels
{
    public class GameSession : NotifyPropertyChangedBase
    {
        /// <summary>
        /// Instatiation of the player 
        /// </summary>
        public Player CurrentPlayer { get; set; }
        
        /// <summary>
        /// Current instance of the world
        /// </summary>
        public World CurrentWorld { get; set; }

        private Location currentLocation;
        /// <summary>
        /// Current location of the of the game session
        /// </summary>
        public Location CurrentLocation
        {
            get { return currentLocation; }
            set
            {
                currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToSouth));
                OnPropertyChanged(nameof(HasLocationToEast));
                OnPropertyChanged(nameof(HasLocationToWest));
            }
        }


        public bool HasLocationToNorth
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCordinate, CurrentLocation.YCordinate + 1) != null; }
        }
        public bool HasLocationToSouth
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCordinate, CurrentLocation.YCordinate - 1) != null; }
        }
        public bool HasLocationToEast
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCordinate + 1, CurrentLocation.YCordinate) != null; }
        }
        public bool HasLocationToWest
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCordinate - 1, CurrentLocation.YCordinate) != null; }
        }
       

        public GameSession()
        {
            CurrentWorld = WorldFactory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(-1, 0);
            CurrentPlayer = PlayerFactory.CreatePlayer("Turtle", "Dan");
        }
        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCordinate, CurrentLocation.YCordinate + 1);
        }
        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCordinate, CurrentLocation.YCordinate - 1);

        }
        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCordinate + 1, CurrentLocation.YCordinate);

        }
        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCordinate - 1, CurrentLocation.YCordinate);

        }
        public void TakeHome()
        {
            CurrentLocation = CurrentWorld.LocationAt(-1, 0);
        }
        public void GivePlayerQuest()
        {
            foreach (Quest quest in CurrentLocation.AvailableQuests)
            {
                if (CurrentPlayer != null && quest != null)
                {
                    if (!CurrentPlayer.Quests.Any(q => q.Id == quest.Id))
                    {
                        CurrentPlayer.Quests.Add(quest);
                    }
                }
            }
        }
    }
}
