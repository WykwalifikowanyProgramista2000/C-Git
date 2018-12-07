using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Wojti";
            CurrentPlayer.Gold = 69;
            CurrentPlayer.CharacterClass = "Nigger";
            CurrentPlayer.ExperiencePoints = 2137;
            CurrentPlayer.HitPoints = 100;
            CurrentPlayer.Level = 1337;
            CurrentPlayer.PortraitName = "/Engine;component/Images/Portraits/Portrait1.png";

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.Description = "Your home is, where your heart belongs";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/Home.png";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
        }

    }
}
