using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API1project.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<user> Users { get; set; }
        public DbSet<flower> Flowers { get; set; }
    }
}
