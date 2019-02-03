using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal class PlayerFactory
    {
        internal Player CreatePlayer(string Class)
        {
            if(Class.ToLower() == "turtle")
            {
                return new Player()
                {
                    PlayerName = "Dan",
                    Class = "Turtle",
                    ExperiencePoints = 0,
                    Level = 1,
                    HitPoints = 100,
                    Gold = 100
                };
            }

            return new Player()
            {
                PlayerName = "Dan",
                Class = "Warrior",
                ExperiencePoints = 0,
                Level = 1,
                HitPoints = 120,
                Gold = 70
            };
        }
    }
}
