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
    public class IndexModel : PageModel
    {
        private readonly HoldsSimpleWebAppCore22.Data.HoldsSimpleWebAppCore22Context _context;

        public IndexModel(HoldsSimpleWebAppCore22.Data.HoldsSimpleWebAppCore22Context context)
        {
            _context = context;
        }

        public IList<OrderHold> OrderHold { get;set; }

        public async Task OnGetAsync()
        {
            OrderHold = await _context.OrderHold.ToListAsync();
        }
    }
}
