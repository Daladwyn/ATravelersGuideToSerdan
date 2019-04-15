using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATravelersGuideToSerdan.Pages.NPC
{
    public class CreateNPCstep3Model : PageModel
    {
        [Key]
        public int NpcPowerId { get; set; }

        [Required]
        public int NpcId { get; set; }

        [Range(0, 6)]
        [Display(Name = "Draken")]
        public byte PowerDragon { get; set; }

        [Range(0, 6)]
        [Display(Name = "Enhörningen")]
        public byte PowerUnicorn { get; set; }

        [Range(0, 5)]
        [Display(Name = "Läkaren")]
        public byte PowerHealer { get; set; }

        [Range(0, 6)]
        [Display(Name = "Gripen")]
        public byte PowerGriffon { get; set; }

        [Range(0, 6)]
        [Display(Name = "Manikoran")]
        public byte PowerManticore { get; set; }

        [Range(0, 5)]
        [Display(Name = "Kroppen")]
        public byte PowerBody { get; set; }

        [Range(0, 6)]
        [Display(Name = "Symbolen")]
        public byte PowerSymbol { get; set; }

        [Range(0, 2)]
        [Display(Name = "Dörren")]
        public byte PowerDoor { get; set; }

        [Range(0, 1)]
        [Display(Name = "Elementa")]
        public byte PowerElementa { get; set; }

        [Range(0, 6)]
        [Display(Name = "Sinnets")]
        public byte PowerMind { get; set; }

        [Range(0, 5)]
        [Display(Name = "Naturen")]
        public byte PowerNature { get; set; }

        [Range(0, 2)]
        [Display(Name = "Djuret")]
        public byte PowerAnimal { get; set; }

        [Range(0, 5)]
        [Display(Name = "Vattnet")]
        public byte PowerWater { get; set; }

        [Range(0, 5)]
        [Display(Name = "Jorden")]
        public byte PowerEarth { get; set; }

        [Range(0, 5)]
        [Display(Name = "Ljuset")]
        public byte PowerLight { get; set; }

        [Range(0, 5)]
        [Display(Name = "Elektricitet")]
        public byte PowerElectricity { get; set; }

        [Range(0, 5)]
        [Display(Name = "Elden")]
        public byte PowerFire { get; set; }

        [Range(0, 5)]
        [Display(Name = "Vinden")]
        public byte PowerWind { get; set; }

        [Range(0, 5)]
        [Display(Name = "Mörkret")]
        public byte PowerDarkness { get; set; }

        [Range(0, 5)]
        [Display(Name = "Svärdet")]
        public byte PowerSword { get; set; }

        [Range(0, 5)]
        [Display(Name = "Materian")]
        public byte PowerMateria { get; set; }

        [Display(Name = "Poäng utsatta på krafter totalt:")]
        public int SummaPoangKrafter { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("CreateNPCstep4");
        }

        public IActionResult OnBack()
        {
            return RedirectToPage("CreateNPCstep2");
        }
    }
}