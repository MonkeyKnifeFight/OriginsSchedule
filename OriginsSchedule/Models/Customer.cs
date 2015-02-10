using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OriginsSchedule.Models
{
    public class Customer : ModelBase
    {
        string fullName;

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
                NotifyPropertyChanged();
            }
        }

        string fullAddress;

        public string FullAddress
        {
            get
            {
                return fullAddress;
            }
            set
            {
                fullAddress = value;
                NotifyPropertyChanged();
            }
        }

        string phone;

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
                NotifyPropertyChanged();
            }
        }

        string email;

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                NotifyPropertyChanged();
            }
        }

    }
}
