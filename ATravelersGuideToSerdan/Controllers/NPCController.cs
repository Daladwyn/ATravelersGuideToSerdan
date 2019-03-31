using Microsoft.AspNetCore.Mvc;
using ATravelersGuideToSerdan.Services;
using ATravelersGuideToSerdan.Models;
using System.Collections.Generic;
using ATravelersGuideToSerdan.ViewModels;

namespace ATravelersGuideToSerdan.Controllers
{
    public class NPCController : Controller
    {
        private ISerdan _Db;

        public NPCController(ISerdan Db)
        {
            _Db = Db;
        }

        // GET: NPC
        public IActionResult NPCIndex()
        {
            return View();
        }

        public IActionResult GetNpcs(string race)
        {
            ViewBag.Title = race;
        
            //List<NPC> ListOfNPCs = ISerdan.GetMultipleNPCs(race);
            List<NPC> RequestedTypeOfNPCs = new List<NPC>();
            List<NpcGeneralViewModel> ConvertedNpcData = new List<NpcGeneralViewModel>();
            NpcGeneralViewModel aConvertedNpc = new NpcGeneralViewModel();
            //foreach (var NPC in ListOfNPCs)
            //{
            //    if (NPC.NpcRace == race)
            //    {
            //        RequestedTypeOfNPCs.Add(NPC);
            //    }
            //}
            foreach (var NPC in RequestedTypeOfNPCs)
            {
                aConvertedNpc.NpcId = NPC.NpcId;
                aConvertedNpc.NpcName = NPC.NpcName;
                ConvertedNpcData.Add(aConvertedNpc);
            }

            return PartialView("_GetNpcList", ConvertedNpcData);


        }

        //public IActionResult GetNpc(int Id)
        //{
        //    NPC selectedNpc = _Db.NPCs.SingleOrDefault(i => i.NpcId == Id);
        //    NpcGeneralViewModel ASpecificNpcData = new NpcGeneralViewModel
        //    {
        //        NpcId = selectedNpc.NpcId,
        //        NpcName = selectedNpc.NpcName,
        //        NpcEvenKnownAs = selectedNpc.NpcEvenKnownAs,
        //        NpcAlias = selectedNpc.NpcAlias,
        //        NpcDescriptivePhrase = selectedNpc.NpcDescriptivePhrase,
        //        NpcArchetyp = selectedNpc.NpcArchetyp,
        //        NpcCurrentResidence = selectedNpc.NpcCurrentResidence,
        //        NpcDescription = selectedNpc.NpcDescription,
        //        NpcFamily = selectedNpc.NpcFamily,
        //        NpcKilledBy = selectedNpc.NpcKilledBy,
        //        NpcLooks = selectedNpc.NpcLooks
        //    };
        //    return PartialView("_SpecificNpc", ASpecificNpcData);
        //}

        //[HttpPost]
        //public IActionResult GetStats(int Id)
        //{
        //    NpcStat NpcToFetch = Db.NpcStats.SingleOrDefault(i => i.NpcId == Id);
        //    if (NpcToFetch == null)
        //    {
        //        ViewBag.ErrorMessage = "No Npc was fetched.";
        //        return PartialView("_GetStats");
        //    }
        //    NpcStatsViewModel NpcStats = NpcStatsViewModel.AssignStatsData(NpcToFetch); ;

        //    return PartialView("_GetStats", NpcStats);
        //}

        //[HttpPost]
        //public IActionResult GetApperance(int Id)
        //{
        //    NPC NpcToFetch = Db.NPCs.SingleOrDefault(i => i.NpcId == Id);
        //    if (NpcToFetch == null)
        //    {
        //        ViewBag.ErrorMessage = "No Npc was fetched.";
        //        return PartialView("_GetApperance");
        //    }
        //    NpcApperanceViewModel NpcApperance = NpcApperanceViewModel.AssignApperanceData(NpcToFetch);
        //    return PartialView("_GetApperance", NpcApperance);
        //}

        //[HttpPost]
        //public IActionResult GetRelatives(int Id)
        //{
        //    NPC NpcToFetch = Db.NPCs.SingleOrDefault(i => i.NpcId == Id);
        //    if (NpcToFetch == null)
        //    {
        //        return PartialView("_GetRelatives");
        //    }
        //    NpcRelativesViewModel NpcRelatives = NpcRelativesViewModel.AssignRelativesData(NpcToFetch);
        //    return PartialView("_GetRelatives", NpcRelatives);
        //}

        //[HttpPost]
        //public IActionResult GetOthers(int Id)
        //{
        //    NPC NpcToFetch = Db.NPCs.SingleOrDefault(i => i.NpcId == Id);
        //    if (NpcToFetch == null)
        //    {
        //        return PartialView("_GetOthers");
        //    }
        //    NpcOthersViewModel NpcOthers = NpcOthersViewModel.AssignOthersData(NpcToFetch);
        //    return PartialView("_GetOthers", NpcOthers);
        //}
        //[HttpPost]
        //public IActionResult GetDiverse(int Id)
        //{
        //    NPC NpcToFetch = Db.NPCs.SingleOrDefault(i => i.NpcId == Id);
        //    if (NpcToFetch == null)
        //    {
        //        return PartialView("_GetDiverse");
        //    }
        //    NpcDiverseViewModel NpcDiverse = NpcDiverseViewModel.AssignDiverseData(NpcToFetch);
        //    return PartialView("_GetDiverse", NpcDiverse);
        //}
    }
}