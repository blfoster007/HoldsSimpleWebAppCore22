using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HoldsSimpleWebApp.Models;
using HoldsSimpleWebAppCore22.Data;

namespace HoldsSimpleWebAppCore22.Pages.OrderHolds
{
    public class CreateModel : PageModel
    {
        private readonly HoldsSimpleWebAppCore22.Data.HoldsSimpleWebAppCore22Context _context;

        public CreateModel(HoldsSimpleWebAppCore22.Data.HoldsSimpleWebAppCore22Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public OrderHold OrderHold { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OrderHold.Add(OrderHold);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}