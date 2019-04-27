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
    public class Step4Model : PageModel
    {
        private IMapper _mapper;
        private _DB _Db;
        public CreateNpc4ViewModel Npc { get; set; }

        public Step4Model(IMapper mapper, _DB Db)
        {
            _mapper = mapper;
            _Db = Db;
        }

        public void OnGet()
        {

        }


        public IActionResult OnPost()
        {
            return RedirectToPage("Step5");
        }

    }
}