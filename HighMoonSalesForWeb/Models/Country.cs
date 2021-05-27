using System.ComponentModel.DataAnnotations;

namespace Covid19_Services_Backend.Models
{
    public class Country
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