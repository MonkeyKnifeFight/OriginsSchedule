using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginsSchedule.ViewModels
{
	class EventViewModel
	{
		public ObservableCollection<Event> Events { get; set}
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
				var rebates = await client.GetTable<Rebate>().Where(r => r.StoreID.ToString() == SelectedStore.Id.ToString()).ToListAsync();

				Rebates.Clear();
				foreach (var rebate in rebates)
				{
					Rebates.Add(rebate);
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
