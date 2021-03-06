﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        
        internal static World CreateWorld()
        {
            QuestFactory questFactory = new QuestFactory();

            World world = new World();
            world.AddLocation(-1, 0, "Home", "This is home", "/Engine;component/Images/Locations/HomeImage.png");
            world.AddLocation(0, 0, "Town Centre", "This the town centre", "/Engine;component/Images/Locations/TownCentre.png");
            world.AddLocation(1, 0, "Forest", "Low level creatures to hunt", "/Engine;component/Images/Locations/ForrestWithPathImage.png", questFactory.CreateQuest(1));
            world.AddLocation(2, 0, "Deep Forrest", "Deeper forrest with harder creatures", "/Engine;component/Images/Locations/ForrestImage.png", questFactory.CreateQuest(2));
            world.AddLocation(0, 1, "Shop", "A shop to get supplies", "/Engine;component/Images/Locations/ShopeCounterImage.png");

            return world;
        }
    }
}
