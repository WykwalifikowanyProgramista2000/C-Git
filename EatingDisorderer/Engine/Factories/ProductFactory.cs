using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class ProductFactory
    {
        private static readonly List<Product> _savedProducts = new List<Product>();

        static ProductFactory()
        {
            _savedProducts.Add(new Product("Egg", 60, 7.56, 0.5, 5.8, 85.8));
            _savedProducts.Add(new Product("Chleb", 25, 2.3, 12.9, 0.4, 55.2));
        }

        public static Product CreateProduct(string itemName)
        {
            Product buffProduct = _savedProducts.FirstOrDefault(prod => prod.Name == itemName);
            
            if(buffProduct != null)
            {
                return buffProduct.Clone();
            }

            return null;
        }
    }
}
