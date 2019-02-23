using Engine.Interfaces.QuestInterfaces;
using System.Collections.Generic;

namespace Engine.Models
{
    public class World
    {
        private List<Location> locations = new List<Location>();

        internal void AddLocation(int x, int y, string name, string description, string imageFilePath, IQuest availableQuest = null)
        {
            Location location = new Location()
            {
                XCordinate = x,
                YCordinate = y,
                Name = name,
                Description = description,
                ImageName = imageFilePath,
                AvailableQuests = { availableQuest }
            };
            locations.Add(location);
        }

        public Location LocationAt(int x, int y)
        {
            Location loc = null;
            foreach (Location location in locations)
            {
                if(location.XCordinate == x && location.YCordinate == y)
                {
                    loc = location;
                }
            }
            return loc;
        }
    }
}
