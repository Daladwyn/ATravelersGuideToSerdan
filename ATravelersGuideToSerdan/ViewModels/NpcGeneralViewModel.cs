using System.ComponentModel.DataAnnotations;

namespace ATravelersGuideToSerdan.ViewModels
{
    public class NpcGeneralViewModel
    {
        [Required]
        public int NpcId { get; set; }

        [Required]
        [MaxLength(40)]
        [Display(Name = "Karaktärsnamn")]
        public string NpcName { get; set; }

        [Display(Name = "Även känd som")]
        public string NpcEvenKnownAs { get; set; }

        [Display(Name = "Alias")]
        [MaxLength(40)]
        public string NpcAlias { get; set; }

        [Display(Name = "Beskrivande fras")]
        [MaxLength(100)]
        public string NpcDescriptivePhrase { get; set; }

        [Display(Name = "Utseende")]
        [MaxLength(100)]
        public string NpcLooks { get; set; }

        [Display(Name = "Beskrivning")]
        [MaxLength(200)]
        public string NpcDescription { get; set; }

        [Display(Name = "Nuvarande Hemvist")]
        [MaxLength(40)]
        public string NpcCurrentResidence { get; set; }

        [Display(Name = "Familj/Hus")]
        [MaxLength(40)]
        public string NpcFamily { get; set; }

        [Display(Name = "Urtyp")]
        public int NpcArchetyp { get; set; }

        [Display(Name = "Dödad av")]
        public int NpcKilledBy { get; set; }
    }
}