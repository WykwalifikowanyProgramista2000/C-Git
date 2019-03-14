using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Model;

namespace MVVM.ViewModels
{
    public class MainViewModel : BaseNotificationClass
    {
        
        private ProszePanstwaMianowicie _proszePanstwaMianowicie;

        public ProszePanstwaMianowicie ProszePanstwaMianowicie
        {
            get { return _proszePanstwaMianowicie; }
            set
            {
                _proszePanstwaMianowicie = value;

                OnPropertyChanged(nameof(ProszePanstwaMianowicie));
            }
        }

        public MainViewModel()
        {
            ProszePanstwaMianowicie = new ProszePanstwaMianowicie();
            ProszePanstwaMianowicie.ProszePanstwa = 0;
            ProszePanstwaMianowicie.Mianowicie = 0;
        }

        public void AddProszePanstwa() 
            => ProszePanstwaMianowicie.ProszePanstwa += 1;

        public void AddMianowicie()
            => ProszePanstwaMianowicie.Mianowicie += 1;

        public void SubtractProszePanstwa()
            => ProszePanstwaMianowicie.ProszePanstwa -= 1;

        public void SubtractMianowicie()
            => ProszePanstwaMianowicie.Mianowicie -= 1;
    }
}
