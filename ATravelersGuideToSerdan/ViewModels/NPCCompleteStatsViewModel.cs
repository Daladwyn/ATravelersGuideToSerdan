using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ATravelersGuideToSerdan.Models.ViewModels
{
    public class NPCCompleteStatsViewModel
    {

        [Required]
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
        [Range(0, 6)]
        [Display(Name = "Draken")]
        public byte PowerDragon { get; set; }

        [Range(0, 6)]
        [Display(Name = "Enhörningen")]
        public byte PowerUnicorn { get; set; }

        [Range(0, 5)]
        [Display(Name = "Läkaren")]
        public byte PowerHealer { get; set; }

        [Range(0, 6)]
        [Display(Name = "Gripen")]
        public byte PowerGriffon { get; set; }

        [Range(0, 6)]
        [Display(Name = "Manikoran")]
        public byte PowerManticore { get; set; }

        [Range(0, 5)]
        [Display(Name = "Kroppen")]
        public byte PowerBody { get; set; }

        [Range(0, 6)]
        [Display(Name = "Symbolen")]
        public byte PowerSymbol { get; set; }

        [Range(0, 2)]
        [Display(Name = "Dörren")]
        public byte PowerDoor { get; set; }

        [Range(0, 1)]
        [Display(Name = "Elementa")]
        public byte PowerElementa { get; set; }

        [Range(0, 6)]
        [Display(Name = "Sinnets")]
        public byte PowerMind { get; set; }

        [Range(0, 5)]
        [Display(Name = "Naturen")]
        public byte PowerNature { get; set; }

        [Range(0, 2)]
        [Display(Name = "Djuret")]
        public byte PowerAnimal { get; set; }

        [Range(0, 5)]
        [Display(Name = "Vattnet")]
        public byte PowerWater { get; set; }

        [Range(0, 5)]
        [Display(Name = "Jorden")]
        public byte PowerEarth { get; set; }

        [Range(0, 5)]
        [Display(Name = "Ljuset")]
        public byte PowerLight { get; set; }

        [Range(0, 5)]
        [Display(Name = "Elektricitet")]
        public byte PowerElectricity { get; set; }

        [Range(0, 5)]
        [Display(Name = "Elden")]
        public byte PowerFire { get; set; }

        [Range(0, 5)]
        [Display(Name = "Vinden")]
        public byte PowerWind { get; set; }

        [Range(0, 5)]
        [Display(Name = "Mörkret")]
        public byte PowerDarkness { get; set; }

        [Range(0, 5)]
        [Display(Name = "Svärdet")]
        public byte PowerSword { get; set; }

        [Range(0, 5)]
        [Display(Name = "Materian")]
        public byte PowerMateria { get; set; }

        [Display(Name = "Poäng utsatta på krafter totalt:")]
        public int SummaPoangKrafter { get; set; }
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
        [Display(Name = "Visuelt")]
        public bool MagiVisuellt { get; set; }

        [Display(Name = "Symbol")]
        public bool MagiSymbol { get; set; }

        [Display(Name = "Alkemi")]
        public bool MagiAlkemi { get; set; }

        [Display(Name = "Blod")]
        public bool MagiBlod { get; set; }

        [Display(Name = "Kraft")]
        public bool MagiKraft { get; set; }

        [Display(Name = "Verkligheten")]
        public bool MagiVerkligheten { get; set; }

        [Display(Name = "Draperiet")]
        public bool MagiDraperiet { get; set; }

        [Display(Name = "Dysterheten")]
        public bool MagiDysterheten { get; set; }

        [Display(Name = "Etnor")]
        public bool MagiEtnor { get; set; }

        [Display(Name = "Drömmen")]
        public bool MagiDrommen { get; set; }

        [Display(Name = "Slöjan")]
        public bool MagiSlojan { get; set; }

        [Display(Name = "Parallellium")]
        public bool MagiParallellium { get; set; }

        [Display(Name = "Elementa")]
        public bool MagiElementa { get; set; }

        [Display(Name = "Se")]
        public bool MagiSe { get; set; }

        [Display(Name = "Öka/minska")]
        public bool MagiOkaMinska { get; set; }

        [Display(Name = "Omvandling")]
        public bool MagiOmvandling { get; set; }

        [Display(Name = "Transformering")]
        public bool MagiTransformering { get; set; }

        [Display(Name = "Skapa")]
        public bool MagiSkapa { get; set; }

        [Display(Name = "Energi")]
        public bool MagiEnergi { get; set; }

        [Display(Name = "Rum")]
        public bool MagiRum { get; set; }

        [Display(Name = "Materia")]
        public bool MagiMateria { get; set; }

        [Display(Name = "Sinne")]
        public bool MagiSinne { get; set; }

        [Display(Name = "Liv")]
        public bool MagiLiv { get; set; }

        [Display(Name = "Själ")]
        public bool MagiSjal { get; set; }

        [Display(Name = "Tid")]
        public bool MagiTid { get; set; }

        [Display(Name = "Summa")]
        public int SummaPoangMagi { get; set; }
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





    }
}
