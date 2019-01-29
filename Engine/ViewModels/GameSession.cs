using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    class GameSession
    {
        /// <summary>
        /// Instatiation of the player 
        /// </summary>
        public Player CurrentPlayer { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.PlayerName = "Dan";
            CurrentPlayer.Gold = 10000000;
        }
    }
}
