using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ATravelersGuideToSerdan.Services;
using ATravelersGuideToSerdan.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ATravelersGuideToSerdan.Pages.Character.CreatePlayer
{
    public class CreatePlayerStep2Model : PageModel
    {
        private ISerdan _Db;
        private IFileSerdan _FilAccess;
        private readonly IHtmlHelper htmlHelper;
        public CreatePlayerStep2Model(ISerdan Db, IFileSerdan filAccess, IHtmlHelper htmlHelper)
        {
            _Db = Db;
            _FilAccess = filAccess;
            this.htmlHelper = htmlHelper;
        }

        [BindProperty]
        public CreatePlayer2ViewModel PlayingCharacterStep2 { get; set; }
        [TempData]
        public string Headline { get; set; }
        [TempData]
        public string Message { get; set; }
        [TempData]
        public string ErrorMessage { get; set; }

        public IActionResult OnGet()
        {
            Headline = "Karaktärsskapandets första steg.";
            Message = "Du behöver ange namn, beskrivning och ditt namn. Sedan har du 100 poäng att sätta ut på grundegenskaper och krafter. ";
            return Page();
        }
    }
}
