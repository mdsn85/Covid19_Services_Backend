using Covid19_Services_Backend.Controllers.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Controllers.Resources
{
    public class CaseResource
    {
        public int CaseId { get; set; }

        public double Lat { get; set; }
        public double Lon { get; set; }
        public int NumberOfCases { get; set; }

        public DateTime Date { get; set; }

        public  CountryResource Country { get; set; }
        public KeyValuePairResource  Status { get; set; }
    }
}
/*
     "Country": "Switzerland",
    "CountryCode": "CH",
    "Lat": "46.82",
    "Lon": "8.23",
    "Cases": 0,
    "Status": "confirmed",
    "Date": "2020-01-22T00:00:00Z"
 */