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
    public class CreateNPCstep3Model : PageModel
    {
        private IMapper _mapper;
        private ISerdan _Db;

        public CreateNPCstep3Model(IMapper mapper, ISerdan Db)
        {
            _mapper = mapper;
            _Db = Db;
        }

        [BindProperty]
        public NpcPower npcToAdd { get; set; }
        [TempData]
        public string messageToUser { get; set; }

        public int nPCId { get; set; }

       

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("CreateNPCstep4");
        }

        public IActionResult OnBack()
        {
            return RedirectToPage("CreateNPCstep2");
        }
    }
}