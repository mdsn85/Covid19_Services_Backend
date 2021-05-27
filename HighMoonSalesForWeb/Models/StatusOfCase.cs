using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Services_Backend.Models
{
    public class StatusOfCase
    {
        public int StatusOfCaseId { get; set; }

        public string Name { get; set; }
    }
}
