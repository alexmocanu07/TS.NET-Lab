using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Mocanu_Alexandru_Rp.Models;

namespace Asp_Mocanu_Alexandru_Rp.Data
{
    public class Asp_Mocanu_Alexandru_RpContext : DbContext
    {
        public Asp_Mocanu_Alexandru_RpContext (DbContextOptions<Asp_Mocanu_Alexandru_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Mocanu_Alexandru_Rp.Models.Movie> Movie { get; set; }
    }
}
