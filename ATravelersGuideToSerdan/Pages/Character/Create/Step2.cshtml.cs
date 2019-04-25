using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATravelersGuideToSerdan.Pages.Character.Create
{
    public class Step2Model : PageModel
    {
        public void OnGet()
        {

        }


        public IActionResult OnPost()
        {
            return RedirectToPage("Step3");
        }
    }
}