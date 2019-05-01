using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATravelersGuideToSerdan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATravelersGuideToSerdan.Pages.Rendezvous
{
    public class IndexModel : PageModel
    {
        public List<NpcListViewModel> Npc1 = new List<NpcListViewModel>();
        public List<NpcListViewModel> Npc2 = new List<NpcListViewModel>();
        public string MeetingDetails = "";
        public List<PlanetViewModel> Planet = new List<PlanetViewModel>();
        public string Place = "";


        

        public void OnGet()
        {

        }
    }
}