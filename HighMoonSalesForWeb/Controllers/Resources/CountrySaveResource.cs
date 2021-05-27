using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Controllers.Resources
{
    public class CountrySaveResource
    {
        public int CountryId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string CountryCode { get; set; }
        [MaxLength(50)]
        public string Slug { get; set; }
    }
}
