using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Controllers.Resources
{
    public class FilterCaseResource
    {
        public int? CountryId { get; set; }
        public DateTime? Date { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAsc { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
