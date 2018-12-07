using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;
namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }

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
            
            WorldFactorie factorie = new WorldFactorie();
            CurrentWorld = factorie.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, 0);
        }

    }
}
