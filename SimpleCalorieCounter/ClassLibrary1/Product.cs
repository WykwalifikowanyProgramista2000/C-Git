using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Product : BaseNotificationClass
    {
        private string _name;    
        private Macroelements _macroelements;

        public Macroelements Macro
        {
            get { return _macroelements; }
            set
            {
                _macroelements = value;
                OnPropertyChanged(nameof(Macro));
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public Product(string name, double kcalValue, double proteinValue, double carbohydrateValue, double fatValue )
        {
            _name = name;
            _macroelements = new Macroelements(kcalValue, proteinValue, carbohydrateValue, fatValue);
        }


    }
}
