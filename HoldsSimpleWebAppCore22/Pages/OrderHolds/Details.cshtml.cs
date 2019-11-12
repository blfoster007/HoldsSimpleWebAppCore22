using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HoldsSimpleWebApp.Models;
using HoldsSimpleWebAppCore22.Data;

namespace HoldsSimpleWebAppCore22.Pages.OrderHolds
{
    public class DetailsModel : PageModel
    {
        private readonly HoldsSimpleWebAppCore22.Data.HoldsSimpleWebAppCore22Context _context;

        public DetailsModel(HoldsSimpleWebAppCore22.Data.HoldsSimpleWebAppCore22Context context)
        {
            _context = context;
        }

        public OrderHold OrderHold { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderHold = await _context.OrderHold.FirstOrDefaultAsync(m => m.OrderHoldID == id);

            if (OrderHold == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
