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

        public string Message { get; set; }

        // [BindProperties]
        public CreateNpc1ViewModel Npc { get; set; }
        //CreateNpc1ViewModel NewNpc = new CreateNpc1ViewModel();

        public void OnGet()
        {
            Message = "Step1 in adding a new Npc";
        }

        public IActionResult OnPost(CreateNpc1ViewModel newNpc)
        {
            Message = "Step1 in adding a new Npc2";
            return RedirectToPage("Step2");
        }
    }
}