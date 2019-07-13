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
    public class Step3Model : PageModel
    {
        private IMapper _mapper;
        private _DB _Db;
        public CreateNpc3ViewModel Npc { get; set; }

        public Step3Model(IMapper mapper, _DB Db)
        {
            _mapper = mapper;
            _Db = Db;
        }

        public string Headline { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            Headline = "Steg 3.";
            Message = "Här anger du karaktärens inställning till andra personer och varelser.";
        }

        public IActionResult OnPost()
        {
            Headline = "Steg 3.";
            Message = "Här anger du karaktärens inställning till andra personer och varelser.";
            return RedirectToPage("Step4");
        }
    }
}