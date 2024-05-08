using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiLeonardoAndrade.DataModels;

namespace ApiLeonardoAndrade.Data
{
    public class ApiLeonardoAndradeContext : DbContext
    {
        public ApiLeonardoAndradeContext (DbContextOptions<ApiLeonardoAndradeContext> options)
            : base(options)
        {
        }

        public DbSet<ApiLeonardoAndrade.DataModels.Burger> Burger { get; set; } = default!;
        public DbSet<ApiLeonardoAndrade.DataModels.Promo> Promo { get; set; } = default!;
    }
}
