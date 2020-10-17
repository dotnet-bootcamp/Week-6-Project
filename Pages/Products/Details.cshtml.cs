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
    public class DetailsModel  : PageModel
    {
        private readonly ProductContext _context;

        public DetailsModel (ProductContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = _context.Product.FirstOrDefault(p => p.ID == id);

            if (Product == null)
            {
                return NotFound();
            }
            
            return Page();
        }

    }
}
