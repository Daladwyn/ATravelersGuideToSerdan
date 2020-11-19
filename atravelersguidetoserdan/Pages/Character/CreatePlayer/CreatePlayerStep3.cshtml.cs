using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATravelersGuideToSerdan.Pages.Character.CreatePlayer
{
    public class CreatePlayerStep3Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            ////create a page to download the stream 
            //CharacterSavedModel savedCharacter = new CharacterSavedModel
            //{
            //    FileName = _FilAccess.CreateCharacterSheet(newPlayer),
            //};
            //return RedirectToPage("CharacterSaved", savedCharacter);
        }
    }
}
