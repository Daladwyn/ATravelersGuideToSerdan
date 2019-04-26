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

        public string Message { get; set; }


        public void OnGet()
        {
            Message = "Step 2 in character creation";
        }

        // @Model.NewNpc.



        public IActionResult OnPost(CreateNpc2ViewModel newNpc)
        {
            return RedirectToPage("Step3");
        }
    }
}