using ATravelersGuideToSerdan.Models;
using System.ComponentModel.DataAnnotations;

namespace ATravelersGuideToSerdan.ViewModels
{
    public class CreateNpc11ViewModel
    {
        [Required]
        public int NpcId { get; set; }

        [Display(Name = "Andra bostäder/platser av betydelse")]
        [MaxLength(200)]
        public string NpcOtherResideces { get; set; }

        [Display(Name = "Historia")]
        [MaxLength(300)]
        public string NpcInTheHistory { get; set; }

        [Display(Name = "Hemligheter")]
        [MaxLength(300)]
        public string NpcSecrets { get; set; }

        [Display(Name = "Tillgångar")]
        [MaxLength(200)]
        public string NpcAssets { get; set; }

        internal static NpcDiverseViewModel AssignDiverseData(NPC NpcToAssign)
        {
            NpcDiverseViewModel FilteredNpc = new NpcDiverseViewModel
            {
                NpcId = NpcToAssign.NpcId,
                NpcOtherResideces = NpcToAssign.NpcOtherResideces,
                NpcInTheHistory = NpcToAssign.NpcInTheHistory,
                NpcSecrets = NpcToAssign.NpcSecrets,
                NpcAssets = NpcToAssign.NpcAssets
            };
            return FilteredNpc;
        }
    }
}