using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Factories;

namespace ClassLibrary1
{
    public class ProgramSession :BaseNotificationClass
    {
        public Product NewProduct { get; set; }
        public ProductDatabase CurrentDatabase { get; set; }

        public ProgramSession()
        {
            NewProduct = new Product("Gówno", 69, 69.1, 69.2, 69.3);

            /*
            StreamReader streamReader = new StreamReader("C:/Users/Wojti/Documents/C#Git/SimpleCalorieCounter/ClassLibrary1/DatabaseTxt.txt");
            char[] delimiter = new char[] { '\t' };
            string[] dataRow;
            dataRow = streamReader.ReadLine().Split(delimiter);

            
            ProductDatabase CurrentDatabase = new ProductDatabase();
            CurrentDatabase.AddProduct(new Product(dataRow[0],
                                            Convert.ToDouble(dataRow[1]),
                                            Convert.ToDouble(dataRow[2]),
                                            Convert.ToDouble(dataRow[3]),
                                            Convert.ToDouble(dataRow[4])));

            NewProduct = CurrentDatabase.GetProductField(0);
            */

            ProductDatabase CurrentDatabase = DatabaseFactorie.LoadDatabase();
        }

    }
}
