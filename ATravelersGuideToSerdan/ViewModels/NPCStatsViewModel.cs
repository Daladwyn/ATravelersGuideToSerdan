using System.ComponentModel.DataAnnotations;

namespace ATravelersGuideToSerdan.Models.ViewModels
{
    public class NpcStatsViewModel 
    {
        [Required]
        public int NpcId { get; set; }

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
        [Display(Name = "Psyke")]
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
        [Display(Name = "Perception")]
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
        [Display(Name = "Sociala")]
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

        //************************************************************

        //************************************************************

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

        internal static NpcStatsViewModel AssignStatsData(NpcStat NpcToAssign)
        {
            NpcStatsViewModel FilteredNpc = new NpcStatsViewModel
            {
                NpcId = NpcToAssign.NpcId,
                KoordinationMotorikTot = NpcToAssign.KoordinationMotorikTot,
                KoordinationMotorikUts = NpcToAssign.KoordinationMotorikUts,
                WeaponValue = NpcToAssign.WeaponValue,
                WeaponExp = NpcToAssign.WeaponExp,
                WeaponSkills = NpcToAssign.WeaponSkills,
                WeaponTalang = NpcToAssign.WeaponTalang,
                WeaponTp = NpcToAssign.WeaponTp,
                WeaponTTp = NpcToAssign.WeaponTTp,
                BalisticExp = NpcToAssign.BalisticExp,
                BalisticSkills = NpcToAssign.BalisticSkills,
                BalisticTalang = NpcToAssign.BalisticTalang,
                BalisticTp = NpcToAssign.BalisticTp,
                BalisticTTp = NpcToAssign.BalisticTTp,
                BalisticValue = NpcToAssign.BalisticValue,
                FineMotorExp = NpcToAssign.FineMotorExp,
                FineMotorSkills = NpcToAssign.FineMotorSkills,
                FineMotorTalang = NpcToAssign.FineMotorTalang,
                FineMotorTp = NpcToAssign.FineMotorTp,
                FineMotorTTp = NpcToAssign.FineMotorTTp,
                FineMotorValue = NpcToAssign.FineMotorValue,
                PhysiqueTot = NpcToAssign.PhysiqueTot,
                PhysiqueUts = NpcToAssign.PhysiqueUts,
                PhysicsValue = NpcToAssign.PhysicsValue,
                PhysicsTp = NpcToAssign.PhysicsTp,
                PhysicsExp = NpcToAssign.PhysicsExp,
                PhysicsTalang = NpcToAssign.PhysicsTalang,
                PhysicsTTp = NpcToAssign.PhysicsTTp,
                PhysicsSkills = NpcToAssign.PhysicsSkills,
                StrenghtExp = NpcToAssign.StrenghtExp,
                StrenghtSkills = NpcToAssign.StrenghtSkills,
                StrenghtTalang = NpcToAssign.StrenghtTalang,
                StrenghtTp = NpcToAssign.StrenghtTp,
                StrenghtTTp = NpcToAssign.StrenghtTTp,
                StrenghtValue = NpcToAssign.StrenghtValue,
                MobilityExp = NpcToAssign.MobilityExp,
                MobilitySkills = NpcToAssign.MobilitySkills,
                MobilityTalang = NpcToAssign.MobilityTalang,
                MobilityTp = NpcToAssign.MobilityTp,
                MobilityTTp = NpcToAssign.MobilityTTp,
                MobilityValue = NpcToAssign.MobilityValue,
                PsykeTot = NpcToAssign.PsykeTot,
                PsykeUts = NpcToAssign.PsykeUts,
                WillExp = NpcToAssign.WillExp,
                WillSkills = NpcToAssign.WillSkills,
                WillTalang = NpcToAssign.WillTalang,
                WillTp = NpcToAssign.WillTp,
                WillTTp = NpcToAssign.WillTTp,
                WillValue = NpcToAssign.WillValue,
                CreativityExp = NpcToAssign.CreativityExp,
                CreativitySkills = NpcToAssign.CreativitySkills,
                CreativityTalang = NpcToAssign.CreativityTalang,
                CreativityTp = NpcToAssign.CreativityTp,
                CreativityTTp = NpcToAssign.CreativityTTp,
                CreativityValue = NpcToAssign.CreativityValue,
                EducationExp = NpcToAssign.EducationExp,
                EducationSkills = NpcToAssign.EducationSkills,
                EducationTalang = NpcToAssign.EducationTalang,
                EducationTp = NpcToAssign.EducationTp,
                EducationTTp = NpcToAssign.EducationTTp,
                EducationValue = NpcToAssign.EducationValue,
                PerceptionTot = NpcToAssign.PerceptionTot,
                PerceptionUts = NpcToAssign.PerceptionUts,
                IntuitionExp = NpcToAssign.IntuitionExp,
                IntuitionSkills = NpcToAssign.IntuitionSkills,
                IntuitionTalang = NpcToAssign.IntuitionTalang,
                IntuitionTp = NpcToAssign.IntuitionTp,
                IntuitionTTp = NpcToAssign.IntuitionTTp,
                IntuitionValue = NpcToAssign.IntuitionValue,
                MagicVisionExp = NpcToAssign.MagicVisionExp,
                MagicVisionSkills = NpcToAssign.MagicVisionSkills,
                MagicVisionTalang = NpcToAssign.MagicVisionTalang,
                MagicVisionTp = NpcToAssign.MagicVisionTp,
                MagicVisionTTp = NpcToAssign.MagicVisionTTp,
                MagicVisionValue = NpcToAssign.MagicVisionValue,
                AttentionExp = NpcToAssign.AttentionExp,
                AttentionSkills = NpcToAssign.AttentionSkills,
                AttentionTalang = NpcToAssign.AttentionTalang,
                AttentionTp = NpcToAssign.AttentionTp,
                AttentionTTp = NpcToAssign.AttentionTTp,
                AttentionValue = NpcToAssign.AttentionValue,
                SocialTot = NpcToAssign.SocialTot,
                SocialUts = NpcToAssign.SocialUts,
                CharismaExp = NpcToAssign.CharismaExp,
                CharismaSkills = NpcToAssign.CharismaSkills,
                CharismaTalang = NpcToAssign.CharismaTalang,
                CharismaTp = NpcToAssign.CharismaTp,
                CharismaTTp = NpcToAssign.CharismaTTp,
                CharismaValue = NpcToAssign.CharismaValue,
                InsightExp = NpcToAssign.InsightExp,
                InsightSkills = NpcToAssign.InsightSkills,
                InsightTalang = NpcToAssign.InsightTalang,
                InsightTp = NpcToAssign.InsightTp,
                InsightTTp = NpcToAssign.InsightTTp,
                InsightValue = NpcToAssign.InsightValue,
                ResistanceExp = NpcToAssign.ResistanceExp,
                ResistanceSkills = NpcToAssign.ResistanceSkills,
                ResistanceTalang = NpcToAssign.ResistanceTalang,
                ResistanceTp = NpcToAssign.ResistanceTp,
                ResistanceTTp = NpcToAssign.ResistanceTTp,
                ResistanceValue = NpcToAssign.ResistanceValue,
                PhysicalDamage = NpcToAssign.PhysicalDamage,
                PhysicalDamageMax = NpcToAssign.PhysicalDamageMax,
                SoulDamage = NpcToAssign.SoulDamage,
                SoulDamageMax = NpcToAssign.SoulDamageMax,
                TotalaPoang = NpcToAssign.TotalaPoang,
                UtdeladePoang = NpcToAssign.UtdeladePoang,
                SparadePoang = NpcToAssign.SparadePoang,
                KraftPoang = NpcToAssign.KraftPoang,
                BundnaKraftPoang = NpcToAssign.BundnaKraftPoang
            };
            return FilteredNpc;
        }
    }
}