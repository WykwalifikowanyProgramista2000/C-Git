using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Engine.Models
{
    class Product : BaseNotificationClass
    {
        private string _name;
        private double _weight;      
        private double _calories;
        private Macroelements _macroelements;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;

                OnPropertyChanged(nameof(Name));
            }
        }
        public double Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged(nameof(Weight));
            }
        }       
        public double Calories
        {
            get { return _calories; }
            set
            {
                _calories = value;
                OnPropertyChanged(nameof(Calories));
            }
        }
        public Macroelements Macroelements
        {
            get { return _macroelements; }
            set
            {
                _macroelements = value;
                OnPropertyChanged(nameof(Macroelements));
            }
        }

        Product(string name, double weight,
                double proteins, double carbs,
                double fats, double calories)
        {
            _name = name;
            _weight = weight;
            _macroelements = new Macroelements(proteins, carbs, fats);
            _calories = calories;
        }


    }
}
