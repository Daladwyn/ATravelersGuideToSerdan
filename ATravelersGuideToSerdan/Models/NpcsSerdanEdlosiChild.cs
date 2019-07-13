using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATravelersGuideToSerdan.Models
{
    public class NpcsSerdanEdlosiChild
    {
        [Required]
        public int NpcsSerdanEdlosiChildId { get; set; }

        [Required]
        public int NpcId { get; set; }

        public int ChildId { get; set; }

        public string ChildName { get; set; }

    }
}
