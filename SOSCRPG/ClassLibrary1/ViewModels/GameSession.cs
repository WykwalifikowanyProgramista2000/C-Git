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

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Wojti";
            CurrentPlayer.Gold = 69;
            CurrentPlayer.CharacterClass = "Nigger";
            CurrentPlayer.ExperiencePoints = 2137;
            CurrentPlayer.HitPoints = 100;
            CurrentPlayer.Level = 1337;
        }

    }
}
