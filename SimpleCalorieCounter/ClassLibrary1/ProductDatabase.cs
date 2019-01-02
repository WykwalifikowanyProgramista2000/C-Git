using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 // update database to be modified with INotify...
{
    public class ProductDatabase
    {
        public string databasePath = "@/ClassLibrary1;components/DatabaseTxt.txt";
        public List<Product> _productList = new List<Product>();

        public List<Product> ProductList
        {
            get { return _productList; }
            set { _productList = value; }
        }

        public Product GetProductField(int productIndex)
        {
            return _productList[productIndex];
        }

        public void AddProduct(Product product)
        {
            _productList.Add(product);
        }



    }
}
