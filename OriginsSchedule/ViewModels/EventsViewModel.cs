using Microsoft.WindowsAzure.MobileServices;
using OriginsSchedule.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OriginsSchedule.ViewModel
{
    public class EventsViewModel : BaseViewModel
    {

        public EventsViewModel()
        {
            this.Events = new ObservableCollection<Event>();
        }

        public EventsViewModel(MobileServiceClient client) : this()
        {
            this.client = client;
            LoadItemsCommand.Execute(null);
        }

        public ObservableCollection<Event> Events { get; set; }


        private Command loadItemsCommand;
        /// <summary>
        /// Command to load/refresh items
        /// </summary>
        public Command LoadItemsCommand
        {
            get { return loadItemsCommand ?? (loadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand())); }
        }

        private async Task ExecuteLoadItemsCommand()
        {
            try
            {
                var events = await client.GetTable<Event>().ToListAsync();

                Events.Clear();
                foreach (var ev in events)
                {
                    Events.Add(ev);
                }
            }
            catch (Exception ex)
            {
                var page = new ContentPage();
                var result = page.DisplayAlert("Error", "Error loading data. Please check connectivity and try again.", "OK", null);
            }
        }
    }
}
