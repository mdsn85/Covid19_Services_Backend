using Covid19_Services_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Models
{
    public class Case
    {
        public int CaseId { get; set; }

        public double Lat { get; set; }
        public double Lon { get; set; }
        public int NumberOfCases { get; set; }

        public DateTime Date { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public int StatusId { get; set; }
        public virtual StatusOfCase Status { get; set; }

   
    }
}
