﻿using ATravelersGuideToSerdan.Core;
using ATravelersGuideToSerdan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATravelersGuideToSerdan.ViewModels
{
    public class CreatePlayer1ViewModel
    {
        [Required]
        public int NpcId { get; set; }

        [Required]
        [MaxLength(40)]
        [Display(Name = "Namn")]
        public string CharacterName { get; set; }

        [Required]
        [MaxLength(40)]
        [Display(Name = "Spelare")]
        public string PlayerName { get; set; }

        [Required]
        [MaxLength(120)]
        [Display(Name = "Beskrivning")]
        public string CharacterDescription { get; set; }

        [Required]
        public int RemainingPoints { get; set; }

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
        [Range(0, 250)]
        [Display(Name = "Draken")]
        public int PowerDragon { get; set; }

        [Range(0, 250)]
        [Display(Name = "Enhörningen")]
        public int PowerUnicorn { get; set; }

        [Range(0, 200)]
        [Display(Name = "Läkaren")]
        public int PowerHealer { get; set; }

        [Range(0, 250)]
        [Display(Name = "Gripen")]
        public int PowerGriffon { get; set; }

        [Range(0, 250)]
        [Display(Name = "Manikoran")]
        public int PowerManticore { get; set; }

        [Range(0, 200)]
        [Display(Name = "Kroppen")]
        public int PowerBody { get; set; }

        [Range(0, 250)]
        [Display(Name = "Symbolen")]
        public int PowerSymbol { get; set; }

        [Range(0, 175)]
        [Display(Name = "Dörren")]
        public int PowerDoor { get; set; }

        [Range(0, 175)]
        [Display(Name = "Tidens")]
        public int PowerTime { get; set; }

        [Range(0, 175)]
        [Display(Name = "Magins")]
        public int PowerMagic { get; set; }

        [Range(0, 100)]
        [Display(Name = "Elementa")]
        public int PowerElementa { get; set; }

        [Range(0, 250)]
        [Display(Name = "Sinnets")]
        public int PowerMind { get; set; }

        [Range(0, 200)]
        [Display(Name = "Naturen")]
        public int PowerNature { get; set; }

        [Range(0, 50)]
        [Display(Name = "Djuret")]
        public int PowerAnimal { get; set; }

        [Range(0, 200)]
        [Display(Name = "Vattnet")]
        public int PowerWater { get; set; }

        [Range(0, 200)]
        [Display(Name = "Jorden")]
        public int PowerEarth { get; set; }

        [Range(0, 200)]
        [Display(Name = "Ljuset")]
        public int PowerLight { get; set; }

        [Range(0, 200)]
        [Display(Name = "Elektricitet")]
        public int PowerElectricity { get; set; }

        [Range(0, 200)]
        [Display(Name = "Elden")]
        public int PowerFire { get; set; }

        [Range(0, 200)]
        [Display(Name = "Vinden")]
        public int PowerWind { get; set; }

        [Range(0, 200)]
        [Display(Name = "Mörkret")]
        public int PowerDarkness { get; set; }

        [Range(0, 200)]
        [Display(Name = "Svärdet")]
        public int PowerSword { get; set; }

        [Range(0, 200)]
        [Display(Name = "Materian")]
        public int PowerMateria { get; set; }

        [Range(0, 50)]
        [Display(Name = "Masken")]
        public int PowerWorm { get; set; }

        [Display(Name = "Poäng utsatta på krafter totalt:")]
        public int PowerAllocatedPoints { get; set; }

        public List<FamilyPower> PowerData { get; set; }

        //public FamilyForce FamilyForce { get; set; }

        //public FamilyForceLevel FamilyForceLevels { get; set; }
        //************************************************************
        [Display(Name = "Visuelt 10p")]
        public bool MagiVisuellt { get; set; }

        [Display(Name = "Symbol 10p")]
        public bool MagiSymbol { get; set; }

        [Display(Name = "Alkemi 10p")]
        public bool MagiAlkemi { get; set; }

        [Display(Name = "Blod 20p")]
        public bool MagiBlod { get; set; }

        [Display(Name = "Kraft 40p")]
        public bool MagiKraft { get; set; }

        [Display(Name = "Verkligheten 20p")]
        public bool MagiVerkligheten { get; set; }

        [Display(Name = "Draperiet 20p")]
        public bool MagiDraperiet { get; set; }

        [Display(Name = "Dysterheten 20p")]
        public bool MagiDysterheten { get; set; }

        [Display(Name = "Etnor 20p")]
        public bool MagiEtnor { get; set; }

        [Display(Name = "Drömmen 30p")]
        public bool MagiDrommen { get; set; }

        [Display(Name = "Slöjan 30p")]
        public bool MagiSlojan { get; set; }

        [Display(Name = "Parallellium 50p")]
        public bool MagiParallellium { get; set; }

        [Display(Name = "Elementa 50p")]
        public bool MagiElementa { get; set; }

        [Display(Name = "1:a Se 5p")]
        public bool MagiSe { get; set; }

        [Display(Name = "2:a Öka/minska 10p")]
        public bool MagiOkaMinska { get; set; }

        [Display(Name = "3:e Omvandling 20p")]
        public bool MagiOmvandling { get; set; }

        [Display(Name = "4:e Transformering 40p")]
        public bool MagiTransformering { get; set; }

        [Display(Name = "5:e Skapa 80p")]
        public bool MagiSkapa { get; set; }

        [Display(Name = "Energi 20p")]
        public bool MagiEnergi { get; set; }

        [Display(Name = "Rum 20p")]
        public bool MagiRum { get; set; }

        [Display(Name = "Materia 20p")]
        public bool MagiMateria { get; set; }

        [Display(Name = "Sinne 20p")]
        public bool MagiSinne { get; set; }

        [Display(Name = "Liv 20p")]
        public bool MagiLiv { get; set; }

        [Display(Name = "Själ 30p")]
        public bool MagiSjal { get; set; }

        [Display(Name = "Tid 40p")]
        public bool MagiTid { get; set; }
        //***********************************************
        [Display(Name = "Drakekontakt 3p")]
        public int ContactDragon { get; set; }

        public string ContactDragonWho { get; set; }

        [Display(Name = "Gripkontakt 3p")]
        public int ContactGrip { get; set; }

        public string ContactGripWho { get; set; }

        [Display(Name = "Demonkontakt 4p")]
        public int ContactDemon { get; set; }

        public string ContactDemonWho { get; set; }

        [Display(Name = "Aetkontakt 4p")]
        public int ContactAet { get; set; }

        public string ContactAetWho { get; set; }

        [Display(Name = "Serdankontakt 4p")]
        public int ContactSerdan { get; set; }

        public string ContactSerdanWho { get; set; }

        [Display(Name = "Edlosikontakt 4p")]
        public int ContactEdlosi { get; set; }

        public string ContactEdlosiWho { get; set; }

        [Display(Name = "Vakande vän 8p")]
        public int ContactWatchman { get; set; }

        public string ContactWatchmanWho { get; set; }

        [Display(Name = "Bra/Dåligt blod")]
        public int ContactBlod { get; set; }

        [Display(Name = "-10, -5, 0, +5, +10")]
        public string ContactBlodValue { get; set; }

        [Display(Name = "Totala poäng:")]
        public int AllocatedPointsTotalPoints { get; set; }
        //************************************************************

        [Display(Name = "Utdelade poäng:")]
        public int AllocatedPointsHandedoutPoints { get; set; }

        [Display(Name = "Sparade poäng:")]
        public int AllocatedPointsSavedPoints { get; set; }

        [Display(Name = "Kraftpoäng:")]
        public int PowerPoints { get; set; }

        [Display(Name = "Bundna kraftpoäng:")]
        public int BoundPowerPoints { get; set; }

        [Display(Name = "Släkt:")]
        public string Relatives { get; set; }

        //public List<Talent> Talents { get; set; }

        public CreatePlayer1ViewModel()
        {

        }

        public CreatePlayer1ViewModel(string sträng)
        {
            KoordinationMotorikTot = 25;
            KoordinationMotorikUts = 0;
            PhysiqueTot = 25;
            PhysiqueUts = 0;
            PsykeTot = 25;
            PsykeUts = 0;
            PerceptionTot = 25;
            PerceptionUts = 0;
            SocialTot = 25;
            SocialUts = 0;
            RemainingPoints = 100;
            PowerData = new List<FamilyPower>
            {
               new FamilyPower() {Id=23,NameOfPower="PowerAnimal",DisplayName="Djuret",NumberOfLevels=3,FamilySpecificPower="" ,CostLvl1=0,CostLvl2=25,CostLvl3=50,CostLvl4=0,CostLvl5=0,CostLvl6=0,CostLvl7=0},
               new FamilyPower() {Id=0,NameOfPower="PowerDragon",DisplayName="Draken",NumberOfLevels=7,FamilySpecificPower="S",CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=250 },
               new FamilyPower() {Id=7,NameOfPower="PowerDoor",DisplayName="Dörren",NumberOfLevels=3,FamilySpecificPower="",CostLvl1=0,CostLvl2=0,CostLvl3=60,CostLvl4=0,CostLvl5=175,CostLvl6=0,CostLvl7=0 },
               new FamilyPower() {Id=17,NameOfPower="PowerFire",DisplayName="Elden",NumberOfLevels=6,FamilySpecificPower="" ,CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=0},
               new FamilyPower() {Id=16,NameOfPower="PowerElectricity",DisplayName="Elektricitet",NumberOfLevels=6,FamilySpecificPower="" ,CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=0},
               new FamilyPower() {Id=11,NameOfPower="PowerElementa",DisplayName="Elementa",NumberOfLevels=3,FamilySpecificPower="" ,CostLvl1=0,CostLvl2=25,CostLvl3=0,CostLvl4=100,CostLvl5=0,CostLvl6=0,CostLvl7=0},
               new FamilyPower() {Id=1,NameOfPower="PowerUnicorn",DisplayName="Enhörningen",NumberOfLevels=7,FamilySpecificPower="S" ,CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=250},
               new FamilyPower() {Id=3,NameOfPower="PowerGriffon",DisplayName="Gripen",NumberOfLevels=7,FamilySpecificPower="E",CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=250 },
               new FamilyPower() {Id=14,NameOfPower="PowerEarth",DisplayName="Jorden",NumberOfLevels=6,FamilySpecificPower="",CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=0 },
               new FamilyPower() {Id=5,NameOfPower="PowerBody",DisplayName="Kroppen",NumberOfLevels=6,FamilySpecificPower="E" ,CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=0},
               new FamilyPower() {Id=15,NameOfPower="PowerLight",DisplayName="Ljuset",NumberOfLevels=6,FamilySpecificPower="S" ,CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=0},
               new FamilyPower() {Id=2,NameOfPower="PowerHealer",DisplayName="Läkaren",NumberOfLevels=6,FamilySpecificPower="S" ,CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=0},
               new FamilyPower() {Id=9,NameOfPower="PowerMagic",DisplayName="Magin",NumberOfLevels=3,FamilySpecificPower="",CostLvl1=0,CostLvl2=0,CostLvl3=60,CostLvl4=0,CostLvl5=175,CostLvl6=0,CostLvl7=0 },
               new FamilyPower() {Id=4,NameOfPower="PowerManticore",DisplayName="Mantikoran",NumberOfLevels=7,FamilySpecificPower="E" ,CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=250},
               new FamilyPower() {Id=10,NameOfPower="PowerWorm",DisplayName="Masken",NumberOfLevels=2,FamilySpecificPower="",CostLvl1=0,CostLvl2=0,CostLvl3=50,CostLvl4=0,CostLvl5=0,CostLvl6=0,CostLvl7=0 },
               new FamilyPower() {Id=21,NameOfPower="PowerMateria",DisplayName="Materia",NumberOfLevels=6,FamilySpecificPower="" ,CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=0},
               new FamilyPower() {Id=19,NameOfPower="PowerDarkness",DisplayName="Mörkret",NumberOfLevels=6,FamilySpecificPower="E" ,CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=0},
               new FamilyPower() {Id=22,NameOfPower="PowerNature",DisplayName="Naturen",NumberOfLevels=6,FamilySpecificPower="" ,CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=0},
               new FamilyPower() {Id=12,NameOfPower="PowerMind",DisplayName="Sinnet",NumberOfLevels=7,FamilySpecificPower="",CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=250 },
               new FamilyPower() {Id=20,NameOfPower="PowerSword",DisplayName="Svärdet",NumberOfLevels=6,FamilySpecificPower="" ,CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=0},
               new FamilyPower() {Id=6,NameOfPower="PowerSymbol",DisplayName="Symbolen",NumberOfLevels=6,FamilySpecificPower="",CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=250 },
               new FamilyPower() {Id=8,NameOfPower="PowerTime",DisplayName="Tiden",NumberOfLevels=3,FamilySpecificPower="" ,CostLvl1=0,CostLvl2=0,CostLvl3=60,CostLvl4=0,CostLvl5=175,CostLvl6=0,CostLvl7=0},
               new FamilyPower() {Id=13,NameOfPower="PowerWater",DisplayName="Vattnet",NumberOfLevels=6,FamilySpecificPower="",CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=0 },
               new FamilyPower() {Id=18,NameOfPower="PowerWind",DisplayName="Vinden",NumberOfLevels=6,FamilySpecificPower="" ,CostLvl1=0,CostLvl2=25,CostLvl3=60,CostLvl4=100,CostLvl5=150,CostLvl6=200,CostLvl7=0},

            };
            //Talents = new List<Talent>
            //{
            //    new Talent(){TalentId = 0,TalentIsBasedOn="Weapon",TalentName="Avväpna",TalentCost1=2,TalentCostFysical=true,NumberOfRequirements=2,TalenReqAttribute1="WeaponValue",TalentReqAttributeValue1=75,TalenReqAttribute2=null,TalentReqAttributeValue2=0,TalentReqTalentSkill1="Vapengrupp",TalentReqTalentSkill2=null,TalentDescription="När användaren strider och har högst stridsvärde kan användaren en gång under striden försöka avväpna sin motståndare. Avväpningen sker inte per automatik utan spelledaren bedömer utifrån skillnaden i stridsvärde och andra omständigheter. Talangen är utan verkan om motståndaren har samma talang eller använder sitt favoritvapen. Naturliga vapen kan inte avväpnas."},
            //    new Talent(){TalentId = 1,TalentIsBasedOn="Weapon",TalentName="Blixtavvärjning",TalentCost1=2,TalentCostFysical=false,NumberOfRequirements=4,TalenReqAttribute1="WeaponValue",TalentReqAttributeValue1=75,TalenReqAttribute2="IntuitionValue",TalentReqAttributeValue2=55,TalentReqTalentSkill1="Undvika",TalentReqTalentSkill2="Ryggmärgsreflexer",TalentDescription="Som Ryggmärgsreflexer men för kastvapen minskar värdet med 30 % (istället för det normala 75 %) och för projektiler minskar värdet med 50 % (istället för det normala 90 %). Blixtavvärjning kan användas istället för Undvika eller Skuggmotståndare men användaren kan då inte anfalla efter att talangen aktiverats."},
            //};
        }
    }

}