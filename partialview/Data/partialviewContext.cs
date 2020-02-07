using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using partialview.Models;

namespace partialview.Data
{
    public class partialviewContext : DbContext
    {
        public partialviewContext (DbContextOptions<partialviewContext> options)
            : base(options)
        {
        }

        public DbSet<partialview.Models.Employ> Employ { get; set; }
    }
}
