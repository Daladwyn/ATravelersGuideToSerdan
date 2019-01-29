using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ATravelersGuideToSerdan.Models.ViewModels
{
    public class NpcOthersViewModel
    {
        [Required]
        public int NpcId { get; set; }

        [Display(Name = "Inställning till Aeter")]
        [MaxLength(100)]
        public string NpcRegardingAets { get; set; }

        [Display(Name = "Inställning till Demoner")]
        [MaxLength(100)]
        public string NpcRegardingDemons { get; set; }

        [Display(Name = "Inställning till Drakar")]
        [MaxLength(100)]
        public string NpcRegardingDragons { get; set; }

        [Display(Name = "Inställning till Gripar")]
        [MaxLength(100)]
        public string NpcRegardingGrips { get; set; }

        [Display(Name = "Inställning till övriga")]
        [MaxLength(100)]
        public string NpcRegardingOthers { get; set; }

        [Display(Name = "Vänner")]
        public List<int> NpcFriends { get; set; }

        [Display(Name = "Allierade")]
        public List<int> NpcAllies { get; set; }

        [Display(Name = "Rivaler")]
        public List<int> NpcRivals { get; set; }

        [Display(Name = "Fiender")]
        public List<int> NpcEnemies { get; set; }

        internal static NpcOthersViewModel AssignOthersData(NPC NpcToAssign)
        {
            NpcOthersViewModel FilteredNpc = new NpcOthersViewModel
            {
                NpcId = NpcToAssign.NpcId,
                NpcAllies = NpcToAssign.NpcAllies,
                NpcEnemies = NpcToAssign.NpcEnemies,
                NpcFriends = NpcToAssign.NpcFriends,
                NpcRegardingAets = NpcToAssign.NpcRegardingAets,
                NpcRegardingDemons = NpcToAssign.NpcRegardingDemons,
                NpcRegardingDragons = NpcToAssign.NpcRegardingDragons,
                NpcRegardingGrips = NpcToAssign.NpcRegardingGrips,
                NpcRegardingOthers = NpcToAssign.NpcRegardingOthers,
                NpcRivals = NpcToAssign.NpcRivals,
            };
            return FilteredNpc;
        }
    }
}