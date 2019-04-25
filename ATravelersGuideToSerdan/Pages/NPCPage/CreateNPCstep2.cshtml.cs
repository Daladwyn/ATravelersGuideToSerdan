using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ATravelersGuideToSerdan.Models;
using ATravelersGuideToSerdan.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATravelersGuideToSerdan.Pages.NPCPage
{
    public class CreateNPCstep2Model : PageModel
    {
        private IMapper _mapper;
        private _DB _Db;

        public CreateNPCstep2Model(IMapper mapper, _DB Db)
        {
            _mapper = mapper;
            _Db = Db;
        }

        [BindProperty]
        public NpcStat NpcToAdd { get; set; }
        [TempData]
        public string MessageToUser { get; set; }

        public int NPCId { get; set; }


        
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {

            return RedirectToPage("CreateNPCstep3");
        }

        public IActionResult OnBack()
        {
            return RedirectToPage("CreateNPCstep1");
        }
        
    }
}