using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductOrder.Model;

namespace ProductOrder.Data
{
    public class ProductOrderContext : DbContext
    {
        public ProductOrderContext (DbContextOptions<ProductOrderContext> options)
            : base(options)
        {
        }

        public DbSet<ProductOrder.Model.Product> Product { get; set; } = default!;
    }
}
