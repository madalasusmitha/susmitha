using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using customerrr.Models;

namespace customerrr.Data
{
    public class customerrrContext : DbContext
    {
        public customerrrContext (DbContextOptions<customerrrContext> options)
            : base(options)
        {
        }

        public DbSet<customerrr.Models.customer> customer { get; set; }
    }
}
