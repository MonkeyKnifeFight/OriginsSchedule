using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using OriginsSchedule.ViewModel;
using OriginsSchedule.Models;

namespace OriginsSchedule.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();

        }

        public void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var customer = e.Item as Customer;
            if (customer == null)
            {
                return;
            }
            Navigation.PushAsync(new Page2(customer));
        }
    }
}
