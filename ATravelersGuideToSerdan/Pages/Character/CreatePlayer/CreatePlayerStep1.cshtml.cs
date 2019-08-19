using ATravelersGuideToSerdan.Services;
using ATravelersGuideToSerdan.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace ATravelersGuideToSerdan.Pages.Character.CreatePlayer
{

    [BindProperties]
    public class CreatePlayerStep1Model : PageModel
    {
        private _DB _Db;
        private IFileSerdan _FilAccess;
        public CreatePlayerStep1Model(_DB Db, IFileSerdan filAccess)
        {
            _Db = Db;
            _FilAccess = filAccess;
        }

        [BindProperty]
        public CreatePlayer1ViewModel PlayingCharacter { get; set; }

       

        //public CreatePlayerStep1Model(IMapper mapper, _DB Db, IFileSerdan filAccess)
        //public CreatePlayerStep1Model(_DB Db, IFileSerdan filAccess)
        //{
        //    // _mapper = mapper;
        //    _Db = Db;
        //    _filAccess = filAccess;
        //}
        [TempData]
        public string Headline { get; set; }
        [TempData]
        public string Message { get; set; }
        [TempData]
        public string ErrorMessage { get; set; }


        public IActionResult OnGet()
        {
            PlayingCharacter = new CreatePlayer1ViewModel("ny");
            Headline = "Karaktärsskapandets första steg.";
            Message = "Du behöver ange namn, beskrivning och ditt namn. Sedan har du 100 poäng att sätta ut på bl.a. grundegenskaper och krafter. ";
            return Page();
        }
        public IActionResult OnPost(object sender, System.EventArgs e)
        {
            var newplayer = PlayingCharacter;
            if (ModelState.IsValid)
            {
               
               var characterSheet =  _FilAccess.CreateCharacterSheet(newplayer);

                //Response.Clear();
                //Response.ContentType = "text/xml";
                //Response.Encoding = System.Text.Encoding.Unicode;
                //Response.BinaryWrite(XmlByteArray);
                //Response.Flush();
                //Response.End();
            }
            else
            {
                return RedirectToPage("CreatePlayerStep1", newplayer);
            }

            return RedirectToPage("CharacterSaved");
        }
    }
}