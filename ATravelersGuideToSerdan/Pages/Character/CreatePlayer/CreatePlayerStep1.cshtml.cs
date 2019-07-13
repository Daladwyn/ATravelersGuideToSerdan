using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATravelersGuideToSerdan.Services;
using ATravelersGuideToSerdan.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATravelersGuideToSerdan.Pages.Character.CreatePlayer
{
    public class CreatePlayerStep1Model : PageModel
    {
        private IMapper _mapper;
        private _DB _Db;

        public CreatePlayerStep1Model(IMapper mapper, _DB Db)
        {
            _mapper = mapper;
            _Db = Db;
        }

        public string Headline { get; set; }
        public string Message { get; set; }

        // [BindProperties]
        public CreatePlayer1ViewModel PlayingCharacter { get; set; }
        public void OnGet()
        {
            Headline = "Karaktärsskapandets första steg.";
            Message = "Du behöver ange namn, beskrivning och ditt namn. Sedan har du 100 poäng att sätta ut på bl.a. grundegenskaper och krafter. ";
        }
        public void OnPost(CreatePlayerStep1Model NewCharacterStep1)
        {

        }
    }
}