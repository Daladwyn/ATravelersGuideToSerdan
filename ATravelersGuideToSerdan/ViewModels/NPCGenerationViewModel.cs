using System.ComponentModel.DataAnnotations;

namespace ATravelersGuideToSerdan.ViewModels
{
    public class NPCGenerationViewModel
    {
        [Required]
        public int NpcId { get; set; }

        [Range(0,7)]
        public byte NPCGeneration { get; set; }

        public string NpcName { get; set; }

    }

}