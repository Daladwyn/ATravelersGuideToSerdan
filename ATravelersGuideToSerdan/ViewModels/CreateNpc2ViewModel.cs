using ATravelersGuideToSerdan.ViewModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ATravelersGuideToSerdan.ViewModels
{

    public class CreateNpc2ViewModel
    {
        [Required]
        public int NpcId { get; set; }

        [Display(Name = "Mor")]
        public string NpcsMother { get; set; }

        public int NpcsMotherId { get; set; }

        [Display(Name = "Far")]
        public string NpcsFather { get; set; }

        public int NpcsFatherId { get; set; }

        [Display(Name = "Serdan/Edlosi barn")]
        public List<NpcListViewModel> NpcsSerdanEdlosiChildren { get; set; }

        [Display(Name = "Vanliga Barn")]
        public List<NpcListViewModel> NpcsRegularChildren { get; set; }


        //internal static NpcRelativesViewModel AssignRelativesData(NPC NpcToAssign)
        //{
        //    SerdanDb Db = new SerdanDb();
        //    NPC NpcFather = Db.NPCs.SingleOrDefault(n => n.NpcId == NpcToAssign.NpcsFather);
        //    NPC NpcMother = Db.NPCs.SingleOrDefault(n => n.NpcId == NpcToAssign.NpcsMother);
        //    NpcRelativesViewModel FilteredNpc = new NpcRelativesViewModel
        //    {
        //        NpcId = NpcToAssign.NpcId,
        //        NpcsFather = NpcFather == null ? "Okänd." : NpcFather.NpcName,
        //        NpcsFatherId= NpcFather == null ? 0 : NpcFather.NpcId,
        //        NpcsMother = NpcMother == null ? "Okänd." : NpcMother.NpcName,
        //        NpcsMotherId = NpcMother == null ? 0: NpcMother.NpcId,
        //        NpcsRegularChildren = GatherTheChildren(NpcToAssign.NpcsRegularChildren),
        //        NpcsSerdanEdlosiChildren = GatherTheChildren(NpcToAssign.NpcsSerdanEdlosiChildren)
        //    };
        //    return FilteredNpc;
        //}
        /// <summary>
        /// Function that returns a list of NpcId and NpcName from a list of NpcIds.
        /// </summary>
        /// <param name="ListOfNumbers"> This is the list from which the children is collected.</param>
        /// <returns></returns>
        //static List<NpcListViewModel> GatherTheChildren(List<int> ListOfNumbers)
        //{
        //    SerdanDb Db = new SerdanDb();
        //    List<NpcListViewModel> childList = new List<NpcListViewModel>();
        //    for (int i = 0; i < ListOfNumbers.Capacity; i++)
        //    {
        //        NPC Child = Db.NPCs.SingleOrDefault(n => n.NpcId == ListOfNumbers[i]);
        //        NpcListViewModel compactChild = new NpcListViewModel
        //        {
        //            NpcId = Child.NpcId,
        //            NpcName = Child.NpcName
        //        };
        //        childList.Add(compactChild);
        //    }
        //    return childList;
        //}
    }
}