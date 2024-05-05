using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryExample.Data;
using InventoryExample.Models;

namespace InventoryExample.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly InventoryExample.Data.InventoryExampleContext _context;

        public IndexModel(InventoryExample.Data.InventoryExampleContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
