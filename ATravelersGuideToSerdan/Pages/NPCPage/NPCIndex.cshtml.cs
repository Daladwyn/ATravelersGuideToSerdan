﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATravelersGuideToSerdan.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATravelersGuideToSerdan.Pages.NPCPage
{
    public class NPCIndexModel : PageModel
    {
        private _DB _Db;

        public NPCIndexModel(_DB Db)
        {
            _Db = Db;
        }

        public void OnGet()
        {
            
        }

        public IActionResult OnPostSelectedRace(string race)
        {
            if (race == null)
            {
                return Page();
            }
            else
            {
                List<Models.NPC> NpcOfARace = new List<Models.NPC>();

                NpcOfARace = _Db.GetMultipleNPCs(race);
                List<ViewModels.NpcListViewModel> compactNpcList = new List<ViewModels.NpcListViewModel>();
                foreach (var npc in NpcOfARace)
                {

                }
                return RedirectToPage("GetNpcList", NpcOfARace);
            }
        }


        //public List<Models.NPC> PageResult GetCharacters(string race)
        //{
        //    List<Models.NPC> NpcOfARace = _Db.GetMultipleNPCs(race);
        //    return Page()
        //}
    }
}