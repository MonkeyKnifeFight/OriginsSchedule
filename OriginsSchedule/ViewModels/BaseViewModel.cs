using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OriginsSchedule.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected MobileServiceClient client;

        private bool isAuthenticated;
        public bool IsAuthenticated
        {
            get { return isAuthenticated; }
            set
            {
                if (value != isAuthenticated)
                {
                    isAuthenticated = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string viewName;

        public virtual string ViewName
        {
            get { return viewName; }
            set
            {
                viewName = value;
                NotifyPropertyChanged();
            }
        }

        public virtual void Refresh()
        {
            NotifyPropertyChanged("ViewName");
            NotifyPropertyChanged("IsAuthenticated");
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}