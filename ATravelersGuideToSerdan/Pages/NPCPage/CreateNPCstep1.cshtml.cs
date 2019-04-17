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
    public class CreateNPCstep1Model : PageModel
    {
        private IMapper _mapper;
        private _DB _Db;

        public CreateNPCstep1Model(IMapper mapper, _DB Db)
        {
            _mapper = mapper;
            _Db = Db;
        }

        [BindProperty]
        public NPC npcToAdd { get; set; }
        [TempData]
        public string messageToUser { get; set; }

        public int nPCId { get; set; }



        public void OnGet()
        {

        }

        //public async Task<IActionResult> OnPostAsync()
        public IActionResult OnPost(NPC npcToAdd)
       // public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //convert data from CreateNPCstep1 to NPCgeneralviewmodel
            //Save to database part1 of the data
            //try
            //{
            //    // _mapper.Map(npcToAdd, npcToAddToDb);
            //    npcToAdd = _Db.AddNPC(npcToAdd);
            //    //_mapper.Map(npcToAddToDb, npcToAdd);
            //}
            //catch (Exception)
            //{
            //    messageToUser = "Ops, something happend!! Either was your data not convertible or not savable.";
            //    return Page();
            //}
            //nPCId = npcToAdd.NpcId;
            //return RedirectToPage("CreateNPCstep2",nPCId);
            return RedirectToPage("CreateNPCstep2");
        }
    }
}