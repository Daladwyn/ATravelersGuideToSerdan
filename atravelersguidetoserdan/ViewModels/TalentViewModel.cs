using ATravelersGuideToSerdan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATravelersGuideToSerdan.ViewModels
{
    public class TalentViewModel
    {
        public List<Talent> TalentData { get; set; }

        public TalentViewModel()
        {
            TalentData = new List<Talent>
            {
                new Talent(){ TalentId = 0, TalentIsBasedOn="Weapon", TalentName="Avväpna", TalentCost1=2, TalentCostFysical=true, NumberOfRequirements=2, TalenReqAttribute1="WeaponValue", TalentReqAttributeValue1=75, TalenReqAttribute2=null, TalentReqAttributeValue2=0, TalentReqTalentSkill1="Vapengrupp", TalentReqTalentSkill2=null, TalentDescription="När användaren strider och har högst stridsvärde kan användaren en gång under striden försöka avväpna sin motståndare. Avväpningen sker inte per automatik utan spelledaren bedömer utifrån skillnaden i stridsvärde och andra omständigheter. Talangen är utan verkan om motståndaren har samma talang eller använder sitt favoritvapen. Naturliga vapen kan inte avväpnas."},
                new Talent(){ TalentId = 1, TalentIsBasedOn="Weapon", TalentName="Blixtavvärjning", TalentCost1=2, TalentCostFysical=false, NumberOfRequirements=4, TalenReqAttribute1="WeaponValue", TalentReqAttributeValue1=75, TalenReqAttribute2="IntuitionValue", TalentReqAttributeValue2=55, TalentReqTalentSkill1="Undvika", TalentReqTalentSkill2="Ryggmärgsreflexer", TalentDescription="Som Ryggmärgsreflexer men för kastvapen minskar värdet med 30 % (istället för det normala 75 %) och för projektiler minskar värdet med 50 % (istället för det normala 90 %). Blixtavvärjning kan användas istället för Undvika eller Skuggmotståndare men användaren kan då inte anfalla efter att talangen aktiverats."},
            };
        }
    }
}
