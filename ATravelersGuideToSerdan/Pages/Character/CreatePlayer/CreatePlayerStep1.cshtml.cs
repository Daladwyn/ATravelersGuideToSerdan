using ATravelersGuideToSerdan.Models;
using ATravelersGuideToSerdan.Services;
using ATravelersGuideToSerdan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ATravelersGuideToSerdan.Pages.Character.CreatePlayer
{

    [BindProperties]
    public class CreatePlayerStep1Model : PageModel
    {
        private ISerdan _Db;
        private IFileSerdan _FilAccess;
        private readonly IHtmlHelper htmlHelper;
        public CreatePlayerStep1Model(ISerdan Db, IFileSerdan filAccess, IHtmlHelper htmlHelper)
        {
            _Db = Db;
            _FilAccess = filAccess;
            this.htmlHelper = htmlHelper;
        }

        [BindProperty]
        public CreatePlayer1ViewModel PlayingCharacterStep1 { get; set; }

        [BindProperty]
        public int PowerDragon { get; set; }

        [BindProperty]
        public int PowerUnicorn { get; set; }

        [BindProperty]
        public int PowerHealer { get; set; }

        [BindProperty]
        public int PowerGriffon { get; set; }

        [BindProperty]
        public int PowerManticore { get; set; }

        [BindProperty]
        public int PowerBody { get; set; }

        [BindProperty]
        public int PowerSymbol { get; set; }

        [BindProperty]
        public int PowerDoor { get; set; }

        [BindProperty]
        public int PowerTime { get; set; }

        [BindProperty]
        public int PowerMagic { get; set; }

        [BindProperty]
        public int PowerElementa { get; set; }

        [BindProperty]
        public int PowerMind { get; set; }

        [BindProperty]
        public int PowerNature { get; set; }

        [BindProperty]
        public int PowerAnimal { get; set; }

        [BindProperty]
        public int PowerWater { get; set; }

        [BindProperty]
        public int PowerEarth { get; set; }

        [BindProperty]
        public int PowerLight { get; set; }

        [BindProperty]
        public int PowerElectricity { get; set; }

        [BindProperty]
        public int PowerFire { get; set; }

        [BindProperty]
        public int PowerWind { get; set; }

        [BindProperty]
        public int PowerDarkness { get; set; }

        [BindProperty]
        public int PowerSword { get; set; }

        [BindProperty]
        public int PowerMateria { get; set; }

        [BindProperty]
        public int PowerWorm { get; set; }

        [TempData]
        public string Headline { get; set; }
        [TempData]
        public string Message { get; set; }
        [TempData]
        public string ErrorMessage { get; set; }


        public IActionResult OnGet()
        {
            PlayingCharacterStep1 = new CreatePlayer1ViewModel("ny");
            Headline = "Karaktärsskapandets första steg.";
            Message = "Du behöver ange namn, beskrivning och ditt namn. Sedan har du 100 poäng att sätta ut på grundegenskaper och krafter. ";
            return Page();
        }
        public IActionResult OnPost()
        {
            var newPlayer = new PlayingCharacter();
            newPlayer
            newPlayer.PowerAnimal = PowerAnimal;
            newPlayer.PowerBody = PowerBody;
            newPlayer.PowerDarkness = PowerDarkness;
            newPlayer.PowerDoor = PowerDoor;
            newPlayer.PowerDragon = PowerDragon;
            newPlayer.PowerEarth = PowerEarth;
            newPlayer.PowerElectricity = PowerElectricity;
            newPlayer.PowerElementa = PowerElementa;
            newPlayer.PowerFire = PowerFire;
            newPlayer.PowerGriffon = PowerGriffon;
            newPlayer.PowerHealer = PowerHealer;
            newPlayer.PowerLight = PowerLight;
            newPlayer.PowerMagic = PowerMagic;
            newPlayer.PowerManticore = PowerManticore;
            newPlayer.PowerMateria = PowerMateria;
            newPlayer.PowerMind = PowerMind;
            newPlayer.PowerNature = PowerNature;
            newPlayer.PowerSword = PowerSword;
            newPlayer.PowerSymbol = PowerSymbol;
            newPlayer.PowerTime = PowerTime;
            newPlayer.PowerUnicorn = PowerUnicorn;
            newPlayer.PowerWater = PowerWater;
            newPlayer.PowerWind = PowerWind;
            newPlayer.PowerWorm = PowerWorm;

            if (ModelState.IsValid)
            {
                //Make Gamerules checks that character statline is ok such as Total points dont exceed 225 
                //and that total of substats is no more that double och base stat
                //check number of talentpoints

                //Save character to DB and return characterID


               
                var savedCharacter = _Db.AddPlayingCharacter(newPlayer);
                return RedirectToPage("CreatePlayerStep2", savedCharacter.PlayingCharacterId);
            }
            else
            {
                return RedirectToPage("CreatePlayerStep1", newPlayer);
            }

            //return RedirectToPage("CharacterSaved");
        }
    }
}