using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        /// <summary>
        /// Instatiation of the player 
        /// </summary>
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.PlayerName = "Dan";
            CurrentPlayer.Gold = 10000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.HitPoints = 100;
            CurrentPlayer.Class = "Turtle";
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCordinate = -1;
            CurrentLocation.YCordinate = 0;
            CurrentLocation.Description = "This is the player home area";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/HomeImage.png";
        }
    }
}
