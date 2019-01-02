using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactorie
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            // AVAILABLE LOCATIONS

            newWorld.AddLocation(0, 0, "Town Square",
                "Smells awful",
                "/Engine;component/Images/Locations/TownSquare.png");

            newWorld.AddLocation(0, -1, "Home",
                "'Your home is, where your toilet is' ~ Unknown",
                "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(1, 0, "Town Gate",
                "Bricks",
                "/Engine;component/Images/Locations/TownGate.png");

            newWorld.AddLocation(2, 0, "Spider Forest",
                "fujka",
                "/Engine;component/Images/Locations/SpiderForest.png");

            newWorld.AddLocation(0, 0, "Trading Shop",
                "The quality :<",
                "/Engine;component/Images/Locations/Trader.png");

            newWorld.AddLocation(-1, -1, "Farm House",
                "farm",
                "/Engine;component/Images/Locations/Farmhouse.png");

            newWorld.AddLocation(-2, -1, "Farm fields",
                "corn",
                "/Engine;component/Images/Locations/FarmFields.png");

            newWorld.AddLocation(0, 1, "Herbalists Hut",
                "420 blaze it",
                "/Engine;component/Images/Locations/HerbalistsHut.png");

            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(0, 2, "Herbalists Garden",
                "The quality :<",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");
            
            return newWorld;
        }
    }
}
