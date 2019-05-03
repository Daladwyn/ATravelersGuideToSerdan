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
    public class Step1Model : PageModel
    {
        private IMapper _mapper;
        private _DB _Db;

        public Step1Model(IMapper mapper, _DB Db)
        {
            _mapper = mapper;
            _Db = Db;
        }

        public string Headline { get; set; }
        public string Message { get; set; }

        // [BindProperties]
        public CreateNpc1ViewModel Npc { get; set; }
        //CreateNpc1ViewModel NewNpc = new CreateNpc1ViewModel();

        public void OnGet()
        {
            Headline = "Steg1.";
            Message = "Här anger du din karaktärs namn och grunddata.";
        }

        public IActionResult OnPost(CreateNpc1ViewModel newNpc)
        {
            Headline = "Steg1.";
            Message = "Här anger du din karaktärs namn och grunddata.";
            return RedirectToPage("Step2");
        }
    }
}