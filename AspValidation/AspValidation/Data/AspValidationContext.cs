using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspValidation.Models
{
    public class AspValidationContext : DbContext
    {
        public AspValidationContext (DbContextOptions<AspValidationContext> options)
            : base(options)
        {
        }

        public DbSet<AspValidation.Models.Product> Product { get; set; }
    }
}
