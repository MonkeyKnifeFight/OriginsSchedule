using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OriginsSchedule.ViewModel;
using Xamarin.Forms;
using OriginsSchedule.Models;
using OriginsSchedule.ViewModel;

namespace OriginsSchedule.Views
{
    public partial class Page2 : ContentPage
    {
        public Page2(Customer customer)
        {
            InitializeComponent();
            BindingContext = customer;
        }

        public Page2()
        {
            InitializeComponent();
        }
    }
}
