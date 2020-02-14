using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Efcdata.Models;


namespace Efcdata
{
   public  class Mycontext:DbContext
    {
        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =DESKTOP-AKFN0I3\SQLEXPRESS; Initial Catalog =practice2db; User ID = SA; Password =pass@word1");
        }
        public DbSet<Project> projects { get; set; }
        public DbSet<Employee> employees { get; set; }


    }
}
