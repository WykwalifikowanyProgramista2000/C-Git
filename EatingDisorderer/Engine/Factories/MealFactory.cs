using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    class MealFactory
    {
        private static readonly List<Meal> _savedMeals = new List<Meal>();

        private static List<Product> _buffList = new List<Product>();
        static MealFactory()
        {   // Jajówa
            _buffList.Add(ProductFactory.CreateProduct("Egg"));
            _buffList.Add(ProductFactory.CreateProduct("Egg"));

            _savedMeals.Add(new Meal("Jajówa"));

            // Chleb z jajkiem
            _buffList.Clear();
            _buffList.Add(ProductFactory.CreateProduct("Egg"));
            _buffList.Add(ProductFactory.CreateProduct("Chleb"));
            
        }

        public static Meal CreateMeal(string name)
        {
            Meal _buffMeal = _savedMeals.FirstOrDefault(prod => prod.Name == name);
            
            if(_buffMeal != null)
            {
                return _buffMeal.Clone();
            }

            return null;
        }        
    }
}
