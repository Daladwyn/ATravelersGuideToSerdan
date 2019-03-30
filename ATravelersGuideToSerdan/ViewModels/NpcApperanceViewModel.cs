using ATravelersGuideToSerdan.Models;
using System.ComponentModel.DataAnnotations;

namespace ATravelersGuideToSerdan.ViewModels
{
    public class NpcApperanceViewModel
    {
        [Required]
        public int NpcId { get; set; }

        [Display(Name = "Uppträdande")]
        [MaxLength(200)]
        public string NpcBehaviour { get; set; }

        [Display(Name = "Som förälder")]
        [MaxLength(200)]
        public string NpcAsAParent { get; set; }

        [Display(Name = "Mål")]
        [MaxLength(200)]
        public string NpcGoal { get; set; }

        [Display(Name = "Strid")]
        [MaxLength(200)]
        public string NpcInBattle { get; set; }

        internal static NpcApperanceViewModel AssignApperanceData(NPC NpcToAssign)
        {
            NpcApperanceViewModel FilteredNpc = new NpcApperanceViewModel
            {
                NpcId = NpcToAssign.NpcId,
                NpcAsAParent = NpcToAssign.NpcAsAParent,
                NpcBehaviour = NpcToAssign.NpcBehaviour,
                NpcGoal = NpcToAssign.NpcGoal,
                NpcInBattle = NpcToAssign.NpcInBattle
            };
            return FilteredNpc;
        }
    }
}