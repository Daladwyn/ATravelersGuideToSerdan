using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATravelersGuideToSerdan.Pages.NPC
{
    public class CreateNPCstep1Model : PageModel
    {

        [BindProperty]
        [Required]
        [MaxLength(40)]
        [Display(Name = "Karaktärsnamn")]
        public string NpcName { get; set; }

        [BindProperty]
        [Display(Name = "Även känd som")]
        public string NpcEvenKnownAs { get; set; }

        [BindProperty]
        [Display(Name = "Alias")]
        [MaxLength(40)]
        public string NpcAlias { get; set; }

        [BindProperty]
        [Display(Name = "Beskrivande fras")]
        [MaxLength(100)]
        public string NpcDescriptivePhrase { get; set; }

        [BindProperty]
        [Display(Name = "Utseende")]
        [MaxLength(100)]
        public string NpcLooks { get; set; }

        [BindProperty]
        [Display(Name = "Beskrivning")]
        [MaxLength(200)]
        public string NpcDescription { get; set; }

        [BindProperty]
        [Display(Name = "Nuvarande Hemvist")]
        [MaxLength(40)]
        public string NpcCurrentResidence { get; set; }

        [BindProperty]
        [Display(Name = "Familj/Hus")]
        [MaxLength(40)]
        public string NpcFamily { get; set; }

        //have to import a list of different archetypes
        [BindProperty]
        [Display(Name = "Urtyp")]
        public string NpcArchetyp { get; set; }

        //Have to import a list of possible Killers
        [BindProperty]
        [Display(Name = "Dödad av")]
        public string NpcKilledBy { get; set; }

        public void OnGet()
        {

        }

        //public async Task<IActionResult> OnPostAsync()
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //convert data from CreateNPCstep1 to NPCgeneralviewmodel
            //Save to database part1 of the data
            //try
            //{
            //    _db.NPC.Add(NPC);
            //    await _db.SaveChangesAsync();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            return RedirectToPage("CreateNPCStep2");
        }
    }
}