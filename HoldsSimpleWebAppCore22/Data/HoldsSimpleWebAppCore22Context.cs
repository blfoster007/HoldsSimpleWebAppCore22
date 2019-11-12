using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HoldsSimpleWebApp.Models;

namespace HoldsSimpleWebAppCore22.Data
{
    public class HoldsSimpleWebAppCore22Context : DbContext
    {
        public HoldsSimpleWebAppCore22Context (DbContextOptions<HoldsSimpleWebAppCore22Context> options)
            : base(options)
        {
        }

        public DbSet<HoldsSimpleWebApp.Models.OrderHold> OrderHold { get; set; }
    }
}
