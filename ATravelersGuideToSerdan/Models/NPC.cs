using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ATravelersGuideToSerdan.Models
{
    public class NPC
    {
        [Key]
        public int NpcId { get; set; }

        [Required]
        [MaxLength(40)]
        [Display(Name = "Karaktärsnamn")]
        public string NpcName { get; set; }

        [Display(Name = "Även känd som")]
        public string NpcEvenKnownAs { get; set; }

        [Display(Name = "Alias")]
        [MaxLength(40)]
        public string NpcAlias { get; set; }

        [Display(Name = "Beskrivande fras")]
        [MaxLength(100)]
        public string NpcDescriptivePhrase { get; set; }

        [Display(Name = "Utseende")]
        [MaxLength(100)]
        public string NpcLooks { get; set; }

        [Display(Name = "Beskrivning")]
        [MaxLength(200)]
        public string NpcDescription { get; set; }

        [Display(Name = "Nuvarande Hemvist")]
        [MaxLength(40)]
        public string NpcCurrentResidence { get; set; }

        [Display(Name ="Ras")]
        [MaxLength(20)]
        public string NpcRace { get; set; }

        public bool NpcIsAPlayer { get; set; }



        [Display(Name = "Familj/Hus")]
        [MaxLength(40)]
        public string NpcFamily { get; set; }

        [Display(Name = "Urtyp")]
        public int NpcArchetyp { get; set; }

        [Display(Name = "Dödad av")]
        public int NpcKilledBy { get; set; }
        
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

        [Display(Name = "Mor")]
        public int NpcsMother { get; set; }

        [Display(Name = "Far")]
        public int NpcsFather { get; set; }

        [Display(Name = "Serdan/Edlosi barn")]
        public List<int> NpcsSerdanEdlosiChildren { get; set; }

        [Display(Name = "Vanliga Barn")]
        public List<int> NpcsRegularChildren { get; set; }

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
    }
}