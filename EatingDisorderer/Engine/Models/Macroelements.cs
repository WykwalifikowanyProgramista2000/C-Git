using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Macroelements
    {
        public double Proteins { get; set; }
        public double Carbohydrates { get; set; }
        public double Fats { get; set; }

        public Macroelements(double proteins,
                      double carbohydrates,
                      double fats)
        {
            Proteins = proteins;
            Carbohydrates = carbohydrates;
            Fats = fats;
        }
    }
}
