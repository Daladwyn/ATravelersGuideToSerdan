using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATravelersGuideToSerdan.Models
{
    public class NpcAlly
    {
        [Required]
        public int NpcAllyId { get; set; }

        [Required]
        public int NpcId { get; set; }

        public int AllyId { get; set; }

        public string AllyName { get; set; }
    }
}
