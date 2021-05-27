using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Extentions
{
    public interface IQueryObject
    {
         string SortBy { get; set; }

         bool IsSortAsc { get; set; }

        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
