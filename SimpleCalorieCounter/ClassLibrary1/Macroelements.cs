using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Macroelements : BaseNotificationClass
    {
        private double _kcalValue;
        private double _proteinsValue;
        private double _carbohydratesValue;
        private double _fatsValue;

        public Macroelements(double kcalValue, double proteinsValue, double carbohydratesValue, double fatsValue)
        {
            _kcalValue = kcalValue;
            _proteinsValue = proteinsValue;
            _carbohydratesValue = carbohydratesValue;
            _fatsValue = fatsValue;
        }

        public double KcalValue
        {
            get { return _kcalValue; }
            set
            {
                _kcalValue = value;
                OnPropertyChanged(nameof(KcalValue));
            }
        }

        public double ProteinsValue
        {
            get { return _proteinsValue; }
            set
            {
                _proteinsValue = value;
                OnPropertyChanged(nameof(ProteinsValue));
            }
        }

        public double CarbohydratesValue
        {
            get { return _carbohydratesValue; }
            set
            {
                _carbohydratesValue = value;
                OnPropertyChanged(nameof(CarbohydratesValue));
            }
        }

        public double FatsValue
        {
            get { return _fatsValue; }
            set
            {
                _fatsValue = value;
                OnPropertyChanged(nameof(FatsValue));
            }
        }
    }
}
