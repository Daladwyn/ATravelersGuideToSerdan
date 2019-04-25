using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATravelersGuideToSerdan.ViewModels
{
    public class CreateNpc6ViewModel
    {
        [Key]
        public int NpcMagicId { get; set; }

        [Required]
        public int NpcId { get; set; }

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
    }
}
