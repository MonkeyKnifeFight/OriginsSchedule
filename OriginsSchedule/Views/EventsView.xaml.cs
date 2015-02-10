using OriginsSchedule.Models;
using OriginsSchedule.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OriginsSchedule.Views
{
    public partial class EventsView
    {
        protected EventsViewModel ViewModel
        {
            get { return this.BindingContext as EventsViewModel; }
            set { this.BindingContext = value; }
        }
        public EventsView()
        {
            InitializeComponent();

            this.ViewModel = new EventsViewModel(App.client);

            eventsList.ItemSelected += EventList_ItemSelected;

         //   btnAdd.Clicked += btnAdd_Clicked;
        }



        void EventList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
            Navigation.PushAsync(new EventDetailView(e.SelectedItem as Event));
            eventsList.SelectedItem = null;
        }
    }
}
