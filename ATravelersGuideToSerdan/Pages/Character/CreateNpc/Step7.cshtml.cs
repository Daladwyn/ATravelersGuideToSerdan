using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATravelersGuideToSerdan.Services;
using ATravelersGuideToSerdan.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATravelersGuideToSerdan.Pages.Character.Create
{
    public class Step7Model : PageModel
    {
        private IMapper _mapper;
        private _DB _Db;
        public CreateNpc7ViewModel Npc { get; set; }

        public Step7Model(IMapper mapper, _DB Db)
        {
            _mapper = mapper;
            _Db = Db;
        }

        public string Headline { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            Headline = "Steg 7";
            Message = "Här kan du välja eventuella kontakter karaktären känner.";
        }

        public IActionResult OnPost()
        {
            Headline = "Steg 7";
            Message = "Här kan du välja eventuella kontakter karaktären känner.";
            return RedirectToPage("Step8");
        }

    }
}