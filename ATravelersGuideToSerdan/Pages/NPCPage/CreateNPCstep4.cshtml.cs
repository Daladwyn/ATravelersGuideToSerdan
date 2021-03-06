﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATravelersGuideToSerdan.Models;
using ATravelersGuideToSerdan.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATravelersGuideToSerdan.Pages.NPCPage
{
    public class CreateNPCstep4Model : PageModel
    {
        private IMapper _mapper;
        private ISerdan _Db;

        public CreateNPCstep4Model(IMapper mapper, ISerdan Db)
        {
            _mapper = mapper;
            _Db = Db;
        }

        [BindProperty]
        public NpcMagic NpcToAdd { get; set; }
        [TempData]
        public string MessageToUser { get; set; }

        public int NPCId { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("");

        }
        public IActionResult OnBack()
        {
            return RedirectToPage("CreateNPCstep3");
        }
    }
}