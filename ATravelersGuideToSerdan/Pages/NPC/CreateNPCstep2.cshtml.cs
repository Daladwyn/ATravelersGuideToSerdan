using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATravelersGuideToSerdan.Pages.NPC
{
    public class CreateNPCstep2Model : PageModel
    {
        [Key]
        public int NpcStatId { get; set; }

        [Required]
        public int NpcId { get; set; }


        //************************************************************
        [Display(Name = "Koordination /Motorik")]
        public int KoordinationMotorikTot { get; set; }

        public int KoordinationMotorikUts { get; set; }
        //************************************************************
        [Display(Name = "Vapen")]
        public int WeaponValue { get; set; }

        public int WeaponTp { get; set; }

        public int WeaponExp { get; set; }

        public string WeaponTalang { get; set; }

        public int WeaponTTp { get; set; }

        public string WeaponSkills { get; set; }
        //************************************************************
        [Display(Name = "Skjutvapen")]
        public int BalisticValue { get; set; }

        public int BalisticTp { get; set; }

        public int BalisticExp { get; set; }

        public string BalisticTalang { get; set; }

        public int BalisticTTp { get; set; }

        public string BalisticSkills { get; set; }
        //************************************************************
        [Display(Name = "Finmotorik")]
        public int FineMotorValue { get; set; }

        public int FineMotorTp { get; set; }

        public int FineMotorExp { get; set; }

        public string FineMotorTalang { get; set; }

        public int FineMotorTTp { get; set; }

        public string FineMotorSkills { get; set; }
        //************************************************************
        [Display(Name = "Kroppsbyggnad")]
        public int PhysiqueTot { get; set; }

        public int PhysiqueUts { get; set; }
        //************************************************************
        [Display(Name = "Fysik")]
        public int PhysicsValue { get; set; }

        public int PhysicsTp { get; set; }

        public int PhysicsExp { get; set; }

        public string PhysicsTalang { get; set; }

        public int PhysicsTTp { get; set; }

        public string PhysicsSkills { get; set; }
        //************************************************************
        [Display(Name = "Styrka")]
        public int StrenghtValue { get; set; }

        public int StrenghtTp { get; set; }

        public int StrenghtExp { get; set; }

        public string StrenghtTalang { get; set; }

        public int StrenghtTTp { get; set; }

        public string StrenghtSkills { get; set; }
        //************************************************************
        [Display(Name = "Rörlighet")]
        public int MobilityValue { get; set; }

        public int MobilityTp { get; set; }

        public int MobilityExp { get; set; }

        public string MobilityTalang { get; set; }

        public int MobilityTTp { get; set; }

        public string MobilitySkills { get; set; }
        //************************************************************
        public int PsykeTot { get; set; }

        public int PsykeUts { get; set; }
        //************************************************************
        [Display(Name = "Vilja")]
        public int WillValue { get; set; }

        public int WillTp { get; set; }

        public int WillExp { get; set; }

        public string WillTalang { get; set; }

        public int WillTTp { get; set; }

        public string WillSkills { get; set; }
        //************************************************************
        [Display(Name = "Kreativitet")]
        public int CreativityValue { get; set; }

        public int CreativityTp { get; set; }

        public int CreativityExp { get; set; }

        public string CreativityTalang { get; set; }

        public int CreativityTTp { get; set; }

        public string CreativitySkills { get; set; }
        //************************************************************
        [Display(Name = "Bildning")]
        public int EducationValue { get; set; }

        public int EducationTp { get; set; }

        public int EducationExp { get; set; }

        public string EducationTalang { get; set; }

        public int EducationTTp { get; set; }

        public string EducationSkills { get; set; }
        //************************************************************
        public int PerceptionTot { get; set; }

        public int PerceptionUts { get; set; }
        //************************************************************
        [Display(Name = "Intuition")]
        public int IntuitionValue { get; set; }

        public int IntuitionTp { get; set; }

        public int IntuitionExp { get; set; }

        public string IntuitionTalang { get; set; }

        public int IntuitionTTp { get; set; }

        public string IntuitionSkills { get; set; }
        //************************************************************
        [Display(Name = "Magisk syn")]
        public int MagicVisionValue { get; set; }

        public int MagicVisionTp { get; set; }

        public int MagicVisionExp { get; set; }

        public string MagicVisionTalang { get; set; }

        public int MagicVisionTTp { get; set; }

        public string MagicVisionSkills { get; set; }
        //************************************************************
        [Display(Name = "Uppm.")]
        public int AttentionValue { get; set; }

        public int AttentionTp { get; set; }

        public int AttentionExp { get; set; }

        public string AttentionTalang { get; set; }

        public int AttentionTTp { get; set; }

        public string AttentionSkills { get; set; }
        //************************************************************
        public int SocialTot { get; set; }

        public int SocialUts { get; set; }
        //************************************************************
        [Display(Name = "Utstrålning")]
        public int CharismaValue { get; set; }

        public int CharismaTp { get; set; }

        public int CharismaExp { get; set; }

        public string CharismaTalang { get; set; }

        public int CharismaTTp { get; set; }

        public string CharismaSkills { get; set; }
        //************************************************************
        [Display(Name = "Insikt")]
        public int InsightValue { get; set; }

        public int InsightTp { get; set; }

        public int InsightExp { get; set; }

        public string InsightTalang { get; set; }

        public int InsightTTp { get; set; }

        public string InsightSkills { get; set; }
        //************************************************************
        [Display(Name = "Motstånd")]
        public int ResistanceValue { get; set; }

        public int ResistanceTp { get; set; }

        public int ResistanceExp { get; set; }

        public string ResistanceTalang { get; set; }

        public int ResistanceTTp { get; set; }

        public string ResistanceSkills { get; set; }
        //************************************************************
        [Display(Name = "Fysisk skada")]
        public int PhysicalDamageMax { get; set; }

        public int PhysicalDamage { get; set; }

        [Display(Name = "Själ skada")]
        public int SoulDamageMax { get; set; }

        public int SoulDamage { get; set; }
        //************************************************************
        [Range(0, 3)]
        [Display(Name = "Drakekontakt 3p")]
        public byte DragonContact { get; set; }

        [MaxLength(50)]
        public string DragonContactWho { get; set; }

        [Range(0, 3)]
        [Display(Name = "Gripkontakt 3p")]
        public byte GriffonContact { get; set; }

        [MaxLength(50)]
        public string GriffonContactWho { get; set; }

        [Range(0, 5)]
        [Display(Name = "Demonkontakt 5p")]
        public byte DemonContact { get; set; }

        [MaxLength(50)]
        public string DemonContactWho { get; set; }

        [Range(0, 5)]
        [Display(Name = "Aetkontakt 5p")]
        public byte AetContact { get; set; }

        [MaxLength(50)]
        public string AetContactWho { get; set; }

        [Range(0, 4)]
        [Display(Name = "Serdankontakt 4p")]
        public byte SerdanContact { get; set; }

        [MaxLength(50)]
        public string SerdanContactWho { get; set; }

        [Range(0, 4)]
        [Display(Name = "Edlosikontakt 4p")]
        public byte EdlosiContact { get; set; }

        [MaxLength(50)]
        public string EdlosiContactWho { get; set; }

        [Range(0, 8)]
        [Display(Name = "Vakande vän 8p")]
        public int GuardianFriend { get; set; }

        [MaxLength(50)]
        public string GuardianFriendWho { get; set; }

        [Range(0, 5)]
        [Display(Name = "Bra/Dåligt blod")]
        public int BraDaligtBlod { get; set; }

        [Display(Name = "Totalt:")]
        public int SummaPoangKontakter { get; set; }
        //************************************************************

        [Display(Name = "Totala poäng:")]
        public int TotalaPoang { get; set; }

        [Display(Name = "Utdelade poäng:")]
        public int UtdeladePoang { get; set; }

        [Display(Name = "Sparade poäng:")]
        public int SparadePoang { get; set; }

        [Display(Name = "Kraftpoäng:")]
        public int KraftPoang { get; set; }

        [Display(Name = "Bundna kraftpoäng:")]
        public int BundnaKraftPoang { get; set; }
        //************************************************************
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {

            return RedirectToPage("CreateNPCstep3");
        }

        public IActionResult OnBack()
        {
            return RedirectToPage("CreateNPCstep1");
        }
        
    }
}