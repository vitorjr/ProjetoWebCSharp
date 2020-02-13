using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AulasMVCWeb.Models;

namespace AulasMVCWeb.Data
{
    public class AulasMVCWebContext : DbContext
    {
        public AulasMVCWebContext (DbContextOptions<AulasMVCWebContext> options)
            : base(options)
        {
        }

        public DbSet<AulasMVCWeb.Models.Department> Department { get; set; }
        public DbSet<AulasMVCWeb.Models.Seller> Seller { get; set; }
        public DbSet<AulasMVCWeb.Models.SalesRecord> SalesRecord { get; set; }
    }
}
