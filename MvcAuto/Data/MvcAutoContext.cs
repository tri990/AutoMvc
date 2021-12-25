using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcAuto.Models;

namespace MvcAuto.Data
{
    public class MvcAutoContext : DbContext
    {
        public MvcAutoContext (DbContextOptions<MvcAutoContext> options)
            : base(options)
        {
        }

        public DbSet<MvcAuto.Models.Auto> Auto { get; set; }

        public DbSet<MvcAuto.Models.Manufacturer> Manufacturer { get; set; }
    }
}
