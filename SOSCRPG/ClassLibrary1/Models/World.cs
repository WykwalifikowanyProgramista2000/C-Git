using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName)
        {
            Location buffLocation = new Location();

            buffLocation.XCoordinate = xCoordinate;
            buffLocation.YCoordinate = yCoordinate;
            buffLocation.Name = name;
            buffLocation.Description = description;
            buffLocation.ImageName = imageName;

            _locations.Add(buffLocation);
        }

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach(Location tmpLocation in _locations)
            {
                if (tmpLocation.XCoordinate == xCoordinate && tmpLocation.YCoordinate == yCoordinate)
                    return tmpLocation;
            }

            return null;
        }
    }
}
