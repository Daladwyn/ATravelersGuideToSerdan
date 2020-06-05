using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATravelersGuideToSerdan.Models
{
    public class Talent
    {
        public int TalentId { get; set; }
        public string TalentIsBasedOn { get; set; }
        public string TalentName { get; set; }
        public int TalentCost1 { get; set; }
        public bool TalentCostFysical { get; set; }
        public int NumberOfRequirements { get; set; }
        public int TalenReqAttribute1 { get; set; }
        public string TalentReqAttributeValue1 { get; set; }
        public int TalenReqAttribute2 { get; set; }
        public string TalentReqAttributeValue2 { get; set; }
        public string TalentReqTalentSkill1 { get; set; }
        public string TalentReqTalentSkill2 { get; set; }
        public string TalentDescription { get; set; }
    }
}
