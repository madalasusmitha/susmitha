using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace customerrr.Models
{
    public class customercontext:DbContext
    {
        public customercontext(DbContextOptions<customercontext> options):base(options)
        { }
        public DbSet<customer> Customers { get; set; }
            }

}
