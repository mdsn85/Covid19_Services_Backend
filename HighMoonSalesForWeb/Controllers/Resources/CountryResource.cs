using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Controllers.Resources
{
    public class CountryResource
    {
        public int CountryId { get; set; }

        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }
    }
}
