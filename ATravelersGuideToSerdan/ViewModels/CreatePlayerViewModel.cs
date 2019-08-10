using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATravelersGuideToSerdan.ViewModels
{
    public class CreatePlayerViewModel
    {
        [Required]
        [MaxLength(40)]
        [Display(Name = "Namn")]
        public string CharacterName { get; set; }

        [Required]
        [MaxLength(40)]
        [Display(Name = "Spelare")]
        public string PlayerName { get; set; }

        [Required]
        [MaxLength(40)]
        [Display(Name = "Beskrivning")]
        public string CharacterDescription { get; set; }
    }
}
