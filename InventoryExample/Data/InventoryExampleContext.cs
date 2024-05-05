using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InventoryExample.Models;

namespace InventoryExample.Data
{
    public class InventoryExampleContext : DbContext
    {
        public InventoryExampleContext (DbContextOptions<InventoryExampleContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryExample.Models.Product> Product { get; set; } = default!;
    }
}
