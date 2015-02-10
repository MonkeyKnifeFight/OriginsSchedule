using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OriginsSchedule.Models;
using OriginsSchedule.ViewModel;
using Xamarin.Forms;

namespace OriginsSchedule.Views
{
    public partial class EventDetailView : ContentPage
    {
        public EventDetailView(Event ev)
        {
            InitializeComponent();
            BindingContext = ev;
        }

        public EventDetailView()
        {
            InitializeComponent();
        }
    }
}
