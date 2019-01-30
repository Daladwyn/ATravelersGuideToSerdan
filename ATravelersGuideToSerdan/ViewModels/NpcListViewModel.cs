using System.ComponentModel.DataAnnotations;

namespace ATravelersGuideToSerdan.Models.ViewModels
{
    public class NpcListViewModel
    {
        [Required]
        public int NpcId { get; set; }

       [Required]
        public string NpcName { get; set; }
    }
}