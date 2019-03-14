using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class ProszePanstwaMianowicie : BaseNotificationClass
    {
        private int _proszePanstwa;
        private int _mianowicie;

        public int ProszePanstwa
        {
            get { return _proszePanstwa; }
            set
            {
                _proszePanstwa = value;

                OnPropertyChanged(nameof(ProszePanstwa));
            }
        }

        public int Mianowicie
        {
            get { return _mianowicie; }
            set
            {
                _mianowicie = value;

                OnPropertyChanged(nameof(Mianowicie));
            }
        }



    }
}
