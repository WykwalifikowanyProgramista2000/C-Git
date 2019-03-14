using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.EventArgs;

namespace Engine.ViewModels
{
    public class MainViewModel : BaseNotificationClass
    {
        public event EventHandler<ViewModelMessageArgs> OnMessageRaised;        

        public MainViewModel()
        {
           
        }

        private void RaiseMessage(string message)
        {
            OnMessageRaised?.Invoke(this, new ViewModelMessageArgs(message));
        }

    }
}
