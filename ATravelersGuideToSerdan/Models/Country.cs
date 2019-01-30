using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ATravelersGuideToSerdan.Models
{
    public class Country
    {
        [Key]
        [Required]
        public int CountryId { get; set; }

        [Required]
        public int PlanetId { get; set; }

        [Required]
        [Display(Name ="Lands namn")]
        [MaxLength(40)]
        public string CountryName { get; set; }

        [MaxLength(40)]
        [Display(Name ="Statsskick")]
        public string Government { get; set; }

        [Display(Name = "Statshuvud")]
        public int HeadOfStateId { get; set; }

        public int CapitalId { get; set; }

        [MaxLength(200)]
        public string CountryDescription { get; set; }

        [MaxLength(500)]
        public string CountryHistory { get; set; }

        [Range(0,50000000)]
        public int CountryPopulation { get; set; }

        //public List<int> ReligionId { get; set; }

        [MaxLength(200)]
        public string CountryClimat { get; set; }

        [MaxLength(200)]
        public string CountryGeography { get; set; }

        [MaxLength(200)]
        public string Fauna { get; set; }

        [MaxLength(200)]
        public string Flora { get; set; }

        [MaxLength(200)]
        public string Export { get; set; }

        [MaxLength(200)]
        public string Import { get; set; }

        [MaxLength(200)]
        public string ArmySize { get; set; }

        [MaxLength(200)]
        public string ArmyStrenght { get; set; }

        [MaxLength(200)]
        public string NavalSize { get; set; }

        [MaxLength(200)]
        public string NavalStrenght { get; set; }
    }
}