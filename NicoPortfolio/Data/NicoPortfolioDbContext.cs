using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using NicoPortfolio.Models;

namespace NicoPortfolio.Models
{


    public class NicoPortfolioDbContext : IdentityDbContext<AppUser>
    {
      





        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(Startup.ConnectionString);
        }

        public NicoPortfolioDbContext(DbContextOptions<NicoPortfolioDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}