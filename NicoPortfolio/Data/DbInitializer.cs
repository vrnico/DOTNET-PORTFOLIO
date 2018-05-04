using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NicoPortfolio.Models;

namespace NicoPortfolio.Data
{
    public class DbInitializer
    {
        public static void Initialize(NicoPortfolioDbContext context)
        {
            if (context.Roles.Any())
            {
                return;
            }


            var roles = new IdentityRole[]
            {
                new IdentityRole() { Name = "Admin" }

            };

          


            foreach (var r in roles)
            {
                context.Roles.Add(r);
            }






            context.SaveChanges();
        }
    }
}