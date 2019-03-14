using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Engine.Models
{
    public class Meal : BaseNotificationClass
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
        public ObservableCollection<Product> ProductList { get; set; }

        public Meal(string name)
        {
            _name = name;

            ProductList = new ObservableCollection<Product>();

            CalculateCalories();
            CalculateMacroelements();
            CalculateWeight();
        }

        public Meal(string name, ObservableCollection<Product> productList)
        {
            _name = name;

            ProductList = productList;

            CalculateCalories();
            CalculateMacroelements();
            CalculateWeight();
        }

        public void AddProduct(Product product)
        {
            ProductList.Add(product);

            CalculateCalories();
            CalculateMacroelements();
            CalculateWeight();

            OnPropertyChanged(nameof(ProductList));
        }
        public void RemoveProduct(Product product)
        {
            ProductList.Remove(product);

            CalculateCalories();
            CalculateMacroelements();
            CalculateWeight();

            OnPropertyChanged(nameof(ProductList));
        }
        public Meal Clone()
        {
            return new Meal(Name, ProductList);
        }

        private void CalculateCalories()
        {
            _calories = ProductList.Sum(i => i.Calories);
        }
        private void CalculateMacroelements()
        {
            _macroelements.Proteins = ProductList.Sum(product => product.Macroelements.Proteins);
            _macroelements.Carbohydrates = ProductList.Sum(product => product.Macroelements.Carbohydrates);
            _macroelements.Fats = ProductList.Sum(product => product.Macroelements.Fats);
        }
        private void CalculateWeight()
        {
            _weight = ProductList.Sum(product => product.Weight);
        }
    }
}
