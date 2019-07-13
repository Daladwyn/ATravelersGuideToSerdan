using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATravelersGuideToSerdan.Models
{
    public class NpcFriend
    {
        [Required]
        public int NpcFriendId { get; set; }

        [Required]
        public int NpcId { get; set; }

        public int FriendId { get; set; }

        public string FriendName { get; set; }

    }
}
