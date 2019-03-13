using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Engine.Models
{
    abstract class Meal : BaseNotificationClass
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
        public ObservableCollection<Product> ProductsList { get; set; }



        public void AddProduct(Product product)
        {
            ProductsList.Add(product);

            OnPropertyChanged(nameof(ProductsList));
        }
        public void RemoveProduct(Product product)
        {
            ProductsList.Remove(product);

            OnPropertyChanged(nameof(ProductsList));
        }
        public void CalculateCalories()
        {
            Calories = Macroelements.Proteins * 4 + Macroelements.Carbohydrates * 4
                        + Macroelements.Fats * 9;
        }
    }
}
