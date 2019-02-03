using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> locations = new List<Location>();

        internal void AddLocation(int x, int y, string name, string description, string imageFilePath)
        {
            Location location = new Location()
            {
                XCordinate = x,
                YCordinate = y,
                Name = name,
                Description = description,
                ImageName = imageFilePath
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
