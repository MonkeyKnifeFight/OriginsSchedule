using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginsSchedule.Models
{
    public class Event : ModelBase
    {
        public Event()
        {

        }
        public Guid Id { get; set; }
        public int eventnumber { get; set; }
        public string eventname { get; set; }

        public string featuretextdescription { get; set; }
        public decimal price { get; set; }
        public string eventcategory { get; set; }
        public DateTime eventdatestarttime { get; set; }
        public DateTime eventduration { get; set; }
        public string trackrequest { get; set; }
        public string ribbonrequest { get; set; }
        public int maximumplayers { get; set; }
        public string hostingcluborcompany { get; set; }
        public string gamemaster { get; set; }
        public string gamemanufacturer { get; set; }

        public string gamerules { get; set; }

        public string gameedition { get; set; }

        public string tournamentstyle { get; set; }

        public string tournamentround { get; set; }

        public string minimumage { get; set; }
        public string gamecomplexity { get; set; }
        public string experience { get; set; }
        public string amountrun { get; set; }
        public string location { get; set; }
        public string materialsprovided { get; set; }
        public string prizesawarded { get; set; }

        

    }
}
