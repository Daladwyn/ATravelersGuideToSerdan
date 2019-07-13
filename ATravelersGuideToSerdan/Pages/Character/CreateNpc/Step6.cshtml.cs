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
    public class Step6Model : PageModel
    {
        private IMapper _mapper;
        private _DB _Db;
        public CreateNpc6ViewModel Npc { get; set; }

        public Step6Model(IMapper mapper, _DB Db)
        {
            _mapper = mapper;
            _Db = Db;
        }

        public string Headline { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            Headline = "Steg6";
            Message = "Här kan du välja magi till din karaktär.";

        }

        public IActionResult OnPost()
        {
            Headline = "Steg6";
            Message = "Här kan du välja magi till din karaktär.";
            return RedirectToPage("Step7");
        }
    }
}