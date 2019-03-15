using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MVVM.Model;

namespace MVVM.ViewModels
{
    public class MainViewModel : BaseNotificationClass
    {
        
        private ProszePanstwaMianowicie _proszePanstwaMianowicie;
        private Wyklad _wyklad;
        private string _momentWykladu;

        public ProszePanstwaMianowicie ProszePanstwaMianowicie
        {
            get { return _proszePanstwaMianowicie; }
            set
            {
                _proszePanstwaMianowicie = value;
                
                OnPropertyChanged(nameof(ProszePanstwaMianowicie));
            }
        }
        public  Wyklad Wyklad
        {
            get { return _wyklad; }
            set
            {
                _wyklad = value;
               
                OnPropertyChanged(nameof(Wyklad));                
            }
        }        
        public string MomentWykladu
        {
            get { return _momentWykladu; }
            set
            {
                _momentWykladu = value;

                OnPropertyChanged(nameof(MomentWykladu));
            }
        }

        public MainViewModel()
        {
            Wyklad = new Wyklad();
            ProszePanstwaMianowicie = new ProszePanstwaMianowicie();
            Wyklad.DlugoscWykladu = 1;
            Wyklad.ProszePanstwaNaMin = 0;            
            SetTimer();
        }
              
        private void SetTimer()
        {
            Timer aTimer = new Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Wyklad.DlugoscWykladu += 1;
            CalcMomentWykladu();
            CalcProszePanstwaNaMin();
            CalcMianowicieNaMin();
        }
       
        public void CalcMomentWykladu()
        {            
            MomentWykladu = TimeSpan.FromSeconds(Wyklad.DlugoscWykladu).ToString();
        }

        public void AddProszePanstwa()
        {
            ProszePanstwaMianowicie.ProszePanstwa += 1;
            CalcProszePanstwaNaMin();
        }
        public void AddMianowicie()
        {
            ProszePanstwaMianowicie.Mianowicie += 1;
            CalcMianowicieNaMin();
        }
        public void SubtractProszePanstwa()
        {
            ProszePanstwaMianowicie.ProszePanstwa -= 1;
            CalcProszePanstwaNaMin();
        }
        public void SubtractMianowicie()
        {
            ProszePanstwaMianowicie.Mianowicie -= 1;
            CalcMianowicieNaMin();
        }

        public void CalcProszePanstwaNaMin()
            => Wyklad.ProszePanstwaNaMin = ProszePanstwaMianowicie.ProszePanstwa / (Wyklad.DlugoscWykladu / 60);
        public void CalcMianowicieNaMin()
            => Wyklad.MianowicieNaMin = ProszePanstwaMianowicie.Mianowicie / (Wyklad.DlugoscWykladu / 60);


    }
}
