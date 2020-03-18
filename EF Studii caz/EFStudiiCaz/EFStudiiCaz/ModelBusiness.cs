using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudiiCaz
{
    public class ModelBusiness : DbContext
    {
        public ModelBusiness() : base("name=ModelBusiness") { }
        public DbSet<Business> Businesses { get; set; }
    }
}
