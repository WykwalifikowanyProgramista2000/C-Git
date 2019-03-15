using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class Wyklad : BaseNotificationClass
    {
        private double _proszePanstwaNaMin;
        private double _mianowicieNaMin;
        private double _dlugoscWykladu;

        public double ProszePanstwaNaMin
        {
            get { return _proszePanstwaNaMin; }
            set
            {
                _proszePanstwaNaMin = Math.Round(value, 2);

                OnPropertyChanged(nameof(ProszePanstwaNaMin));
            }
        }
        public double MianowicieNaMin
        {
            get { return _mianowicieNaMin; }
            set
            {
                _mianowicieNaMin = Math.Round(value, 2);                

                OnPropertyChanged(nameof(MianowicieNaMin));
            }
        }
        public double DlugoscWykladu
        {
            get { return _dlugoscWykladu; }
            set
            {
                _dlugoscWykladu = Math.Round(value, 2);
                OnPropertyChanged(nameof(DlugoscWykladu));
            }
        }

        public Wyklad()
        {
            _proszePanstwaNaMin = 0;
            _mianowicieNaMin = 0;
            _dlugoscWykladu = 1;
        }
      
    }
}
