using ATravelersGuideToSerdan.Core;
using ATravelersGuideToSerdan.Services;
using ATravelersGuideToSerdan.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ATravelersGuideToSerdan.Pages.Character.CreatePlayer
{

    [BindProperties]
    public class CreatePlayerStep1Model : PageModel
    {
        private _DB _Db;
        private IFileSerdan _FilAccess;
        private readonly IHtmlHelper htmlHelper;
        public CreatePlayerStep1Model(_DB Db, IFileSerdan filAccess, IHtmlHelper htmlHelper)
        {
            _Db = Db;
            _FilAccess = filAccess;
            this.htmlHelper = htmlHelper;
        }

        [BindProperty]
        public CreatePlayer1ViewModel PlayingCharacter { get; set; }

        public IEnumerable<SelectListItem> FamilyForces { get; set; }
        public IEnumerable<SelectListItem> FamilyForceLevels { get; set; }


        [TempData]
        public string Headline { get; set; }
        [TempData]
        public string Message { get; set; }
        [TempData]
        public string ErrorMessage { get; set; }


        public IActionResult OnGet()
        {
            PlayingCharacter = new CreatePlayer1ViewModel("ny");
            FamilyForces = htmlHelper.GetEnumSelectList<FamilyForce>();
            FamilyForceLevels = htmlHelper.GetEnumSelectList<FamilyForceLevel>();
            Headline = "Karaktärsskapandets första steg.";
            Message = "Du behöver ange namn, beskrivning och ditt namn. Sedan har du 100 poäng att sätta ut på bl.a. grundegenskaper och krafter. ";
            return Page();
        }
        public IActionResult OnPost()
        {
            var newplayer = PlayingCharacter;
            if (ModelState.IsValid)
            {
                //create a page to download the stream 

                CharacterSavedModel savedCharacter = new CharacterSavedModel
                {
                    FileName = _FilAccess.CreateCharacterSheet(newplayer),
                };
                return RedirectToPage("CharacterSaved", savedCharacter);

            }
            else
            {
                return RedirectToPage("CreatePlayerStep1", newplayer);
            }

            return RedirectToPage("CharacterSaved");
        }
    }
}