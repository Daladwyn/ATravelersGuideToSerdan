using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATravelersGuideToSerdan.Models
{
    public class NpcEnemy
    {
        [Required]
        public int NpcEnemyId { get; set; }

        [Required]
        public int NpcId { get; set; }

        public int EnemyId { get; set; }

        public string EnemyName { get; set; }
    }
}
