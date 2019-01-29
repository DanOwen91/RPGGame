using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    /// <summary>
    /// Character Class
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Player's name
        /// </summary>
        public string PlayerName { get; set; }
        /// <summary>
        /// Player's class
        /// </summary>
        public string Class { get; set; }
        /// <summary>
        /// Player's level
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// Player's hit points
        /// </summary>
        public int HitPoints { get; set; }
        /// <summary>
        /// Player's gold amount
        /// </summary>
        public int Gold { get; set; }
        /// <summary>
        /// Player's experience points
        /// </summary>
        public int ExperiencePoints { get; set; }

    }
}
