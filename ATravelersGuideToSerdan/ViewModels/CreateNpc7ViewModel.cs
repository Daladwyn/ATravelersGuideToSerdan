using System.ComponentModel.DataAnnotations;

namespace ATravelersGuideToSerdan.ViewModels
{
    public class CreateNpc7ViewModel
    {
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
    }
}