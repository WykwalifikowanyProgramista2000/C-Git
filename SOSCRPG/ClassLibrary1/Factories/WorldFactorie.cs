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

        // TOWN SQUARE
            newWorld.AddLocation(0, 0, "Town Square",
                "Smells awful",
                "TownSquare.png");

        // HOME
            newWorld.AddLocation(0, -1, "Home",
                "'Your home is, where your toilet is' ~ Unknown",
                "Home.png");
        
        // TOWN GATE
            newWorld.AddLocation(1, 0, "Town Gate",
                "Bricks",
                "TownGate.png");

        // SPIDER FOREST
            newWorld.AddLocation(2, 0, "Spider Forest",
                "fujka",
                "SpiderForest.png");
            newWorld.LocationAt(2, 0).AddMonster(3, 100);

        // TRADING SHOP
            newWorld.AddLocation(-1, 0, "Trading Shop",
                "The quality :<",
                "Trader.png");
            newWorld.LocationAt(-1, 0).TraderHere = TraderFactory.GetTraderByName("Susan");

        // FARM HOUSE
            newWorld.AddLocation(-1, -1, "Farm House",
                "farm",
                "Farmhouse.png");
            newWorld.LocationAt(-1, -1).TraderHere = TraderFactory.GetTraderByName("Farmer Ted");

        // FARMERS FIELD
            newWorld.AddLocation(-2, -1, "Farm fields",
                "corn",
                "FarmFields.png");
            newWorld.LocationAt(-2, -1).AddMonster(2, 100);

        // HERBALIST HUT
            newWorld.AddLocation(0, 1, "Herbalists Hut",
                "420 blaze it",
                "HerbalistsHut.png");
            newWorld.LocationAt(0, 1).TraderHere = TraderFactory.GetTraderByName("Pete the Herbalist");

            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

        // HERBALIST GARDEN
            newWorld.AddLocation(0, 2, "Herbalists Garden",
                "The quality :<",
                "HerbalistsGarden.png");
            newWorld.LocationAt(0, 2).AddMonster(1, 100);

            return newWorld;
        }
    }
}
