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
    public class Step2Model : PageModel
    {
        private IMapper _mapper;
        private _DB _Db;
        public CreateNpc2ViewModel Npc { get; set; }

        public Step2Model(IMapper mapper, _DB Db)
        {
            _mapper = mapper;
            _Db = Db;
        }

        public string Headline { get; set; }
        public string Message { get; set; }


        public void OnGet()
        {
            Headline = "Steg2";
            Message = "Här anger du karaktärens släktband";
        }

        // @Model.NewNpc.



        public IActionResult OnPost(CreateNpc2ViewModel newNpc)
        {
            Headline = "Steg2";
            Message = "Här anger du karaktärens släktband";
            return RedirectToPage("Step3");
        }
    }
}