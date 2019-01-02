using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Factories
{
    internal static class DatabaseFactorie
    {
        internal static ProductDatabase LoadDatabase()
        {
            ProductDatabase CurrentProductDatabase = new ProductDatabase();

            StreamReader streamReader = new StreamReader("C:/Users/Wojti/Documents/C#Git/SimpleCalorieCounter/ClassLibrary1/DatabaseTxt.txt");
            char[] delimiter = new char[] { '\t' };
            Product buffProduct = new Product("name", 0, 0, 0, 0);
            string[] dataRow = { "n", "1", "1", "1", "1" };


            while (dataRow[0] != null) // to be fixed - currently loading a single element form database defienietly is working
            {
                buffProduct = new Product(dataRow[0],
                                            Convert.ToDouble(dataRow[1]),
                                            Convert.ToDouble(dataRow[2]),
                                            Convert.ToDouble(dataRow[3]),
                                            Convert.ToDouble(dataRow[4]));

                CurrentProductDatabase.AddProduct(buffProduct);
                dataRow = streamReader.ReadLine().Split(delimiter);
            }
            
            return CurrentProductDatabase;
        }
    }
}
