using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using razorpages.Data;
using razorpages.Models;

namespace razorpages.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductContext _context;

        public IndexModel(ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get; set; }

        public void OnGet()
        {
            Products = _context.Product.ToList();
        }
    }
}
