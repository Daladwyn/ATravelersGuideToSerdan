﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATravelersGuideToSerdan.Services;
using ATravelersGuideToSerdan.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATravelersGuideToSerdan.Pages.Character.Create
{
    public class Step5Model : PageModel
    {
        private IMapper _mapper;
        private _DB _Db;
        public CreateNpc4ViewModel Npc { get; set; }

        public Step5Model(IMapper mapper, _DB Db)
        {
            _mapper = mapper;
            _Db = Db;
        }

        public string Headline { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {

            Headline = "Steg 5";
            Message = "I detta steget  kommer du kunna välja färdigheter och talanger.";

        }

        public IActionResult OnPost()
        {
            Headline = "Steg 5";
            Message = "I detta steget  kommer du kunna välja färdigheter och talanger.";
            return RedirectToPage("Step6");
        }
    }
}