using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ATravelersGuideToSerdan.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        [MaxLength(40)]
        public string CityName { get; set; }

        public bool CityIsCapital { get; set; }

        [Required]
        public int CountryId { get; set; }

        [MaxLength(200)]
        public string CityDescription { get; set; }

        [Range(0,20000000)]
        public int CityPopulation { get; set; }

        public List<int> PlacesOfInterests { get; set; }


    }
}