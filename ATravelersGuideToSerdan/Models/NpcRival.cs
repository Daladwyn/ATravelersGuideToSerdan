using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATravelersGuideToSerdan.Models
{
    public class NpcRival
    {
        [Required]
        public int NpcRivalId { get; set; }
        
        [Required]
        public int NpcId { get; set; }

        public int RivalId { get; set; }

        public string RivalName { get; set; }

    }
}
