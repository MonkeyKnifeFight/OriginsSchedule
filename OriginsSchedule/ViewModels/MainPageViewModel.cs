using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OriginsSchedule.Models;


namespace OriginsSchedule.ViewModel
{
    public class MainPageViewModel
    {
        public List<Customer> Customers
        {
            get
            {
                return new List<Customer> {
                    new Customer {
                        FullName = "Jesse Liberty",
                        FullAddress = "1 Main Street, Boston, MA",
                        Phone = "617-555-1212",
                        Email = "jesse@falafel.com"
                    },
                    new Customer {
                        FullName = "Steve Smith",
                        FullAddress = "24 East Street, Hudson, OH",
                        Phone = "978-555-1234",
                        Email = "Steve.Smith@falafel.com"
                    },
                    new Customer {
                        FullName = "Casey Stengel",
                        FullAddress = "24 Flatbush Avenue, Brooklyn, NY 10212",
                        Phone = "212-555-4321",
                        Email = "Casey@Dodgers.com"
                    }
                };
            }
        }

		
	}
}
