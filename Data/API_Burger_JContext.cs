using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_Burger_J.Data.Models;

namespace API_Burger_J.Data
{
    public class API_Burger_JContext : DbContext
    {
        public API_Burger_JContext (DbContextOptions<API_Burger_JContext> options)
            : base(options)
        {
        }

        public DbSet<API_Burger_J.Data.Models.Burger> Burger { get; set; } = default!;
    }
}
