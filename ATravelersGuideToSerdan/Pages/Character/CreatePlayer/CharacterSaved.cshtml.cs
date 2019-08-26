using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATravelersGuideToSerdan.Pages.Character.CreatePlayer
{
    [BindProperties]
    public class CharacterSavedModel : PageModel
    {
        public string FileName { get; set; }
        public void OnGet(string fileName)
        {
            FileName = "//localhost:44311/"+fileName;
           
        }
    }
}