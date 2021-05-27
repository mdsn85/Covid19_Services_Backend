using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Covid19_Services_Backend.Models
{
    //A summary of new and total cases per country updated daily.

    public class SummaryCovidPerDay
    {
        public int SummaryCovidPerDayId { get; set; }
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }
        public DateTime Date { get; set; }


        public int CountryId { get; set; }
        public virtual Country Country { get; set; }


    }


}